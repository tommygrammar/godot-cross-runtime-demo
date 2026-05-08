using System;
using System.Threading.Tasks;
using GodotWeb;
using System.Numerics; 

public static class DotRunner
{
    
    private const int ScreenWidth = 1024;
    private const int ScreenHeight = 768;
    private const float Gravity = 50.0f;
    private const float Damping = 0.99f;
    private const float BounceDamping = 0.85f;
    private const float MaxSpeed = 1200.0f;
    private const float TurbulenceStrength = 800.0f;

    
    // Godot expects 8 floats per instance for TRANSFORM_2D
    private const int FloatsPerInstance = 8;

    private static Vector2[] _positions = Array.Empty<Vector2>();
    private static Vector2[] _velocities = Array.Empty<Vector2>();
    private static float[] _buffer = Array.Empty<float>();

    private static uint _rngState = 0x12345678u;
    private static int _dotCount = 0;
    private static MultiMesh? _multiMesh;

    public static async Task Run(int dotCount = 1000)
    {
        _dotCount = dotCount;

        // Get singleton
        ulong sceneTreeId = Engine.get_singleton();
        if (sceneTreeId == 0) return;
        // Create new scene tree
        SceneTree tree = new SceneTree(sceneTreeId);
        ulong rootId = tree.get_root(); //get root
        Node root = new Node(rootId); //get node

        // find nodes
        ulong mainId = root.find_child("Main", true, false);
        if (mainId == 0) { Console.WriteLine("[DotRunner] Main node missing."); return; }
        Node main = new Node(mainId); //create new node

        ulong dotsNodeId = main.find_child("Dots", true, false);
        if (dotsNodeId == 0) { Console.WriteLine("[DotRunner] Dots node missing."); return; }
        
        MultiMeshInstance2D dotsInstance = new MultiMeshInstance2D(dotsNodeId);
        ulong multiMeshId = dotsInstance.get_multimesh();
        
        if (multiMeshId == 0) { Console.WriteLine("[DotRunner] No MultiMesh resource."); return; }

        MultiMesh multiMesh = new MultiMesh(multiMeshId);
        _multiMesh = multiMesh;

        //configure the buffer
        multiMesh.set_transform_format(0); 
        multiMesh.set_use_colors(false);
        multiMesh.set_use_custom_data(false);
        
        // allocates the memory
        multiMesh.set_instance_count(dotCount);
        multiMesh.set_visible_instance_count(dotCount);

        // Initializes
        InitDots(dotCount);
        
        // Initial Render
        PushBufferToMultiMesh();

        Console.WriteLine($"[DotRunner] Running {dotCount} dots.");


        //simulation looop
        const float dt = 1.0f / 60.0f;

        
        while (true)
        {
            StepSimulation(dt);
            PushBufferToMultiMesh();
            //await Task.Delay(16);
        }
    }

    private static void InitDots(int count)
    {
        _positions = new Vector2[count];
        _velocities = new Vector2[count];
        _buffer = new float[count * FloatsPerInstance];
        
        for (int i = 0; i < count; i++)
        {
            float x = NextRandomFloat() * ScreenWidth;
            float y = NextRandomFloat() * ScreenHeight;
            
            // Explosive start
            float vx = (NextRandomFloat() - 0.5f) * 800.0f;
            float vy = (NextRandomFloat() - 0.5f) * 800.0f;

            _positions[i] = new Vector2(x, y);
            _velocities[i] = new Vector2(vx, vy);
        }
    }

    private static void StepSimulation(float dt)
    {
        // Cache bounds for speed
        float w = (float)ScreenWidth;
        float h = (float)ScreenHeight;

        for (int i = 0; i < _dotCount; i++)
        {
            Vector2 p = _positions[i];
            Vector2 v = _velocities[i];

            // Physics
            float turbX = (NextRandomFloat() - 0.5f) * TurbulenceStrength;
            float turbY = (NextRandomFloat() - 0.5f) * TurbulenceStrength;

            v.X += turbX * dt;
            v.Y += (Gravity + turbY) * dt;
            v.X *= Damping;
            v.Y *= Damping;
            p.X += v.X * dt;
            p.Y += v.Y * dt;

            // Bounce Logic
            if (p.X < 0) { p.X = 0; v.X = -v.X * BounceDamping; }
            else if (p.X > w) { p.X = w; v.X = -v.X * BounceDamping; }

            if (p.Y < 0) { p.Y = 0; v.Y = -v.Y * BounceDamping; }
            else if (p.Y > h) { p.Y = h; v.Y = -v.Y * BounceDamping; }

            _positions[i] = p;
            _velocities[i] = v;
        }
    }

    
    private static void PushBufferToMultiMesh()
    {
        if (_multiMesh == null) return;

        const float s = 4.0f; // Dot scale
        
        for (int i = 0; i < _dotCount; i++)
        {
            int b = i * FloatsPerInstance;
            Vector2 p = _positions[i];
            
            // Row 1
            _buffer[b + 0] = s;    // Scale X
            _buffer[b + 1] = 0.0f; // Skew Y
            _buffer[b + 2] = 0.0f; // Unused (Z)
            _buffer[b + 3] = p.X;  // Position X (Origin.x)

            // Row 2
            _buffer[b + 4] = 0.0f; // Skew X
            _buffer[b + 5] = s;    // Scale Y
            _buffer[b + 6] = 0.0f; // Unused (Z)
            _buffer[b + 7] = p.Y;  // Position Y (Origin.y)
        }

        _multiMesh.set_buffer(_buffer);
    }

    private static float NextRandomFloat()
    {
        _rngState ^= _rngState << 13;
        _rngState ^= _rngState >> 17;
        _rngState ^= _rngState << 5;
        return (_rngState & 0xFFFFFF) / 16777215.0f;
    }
}
