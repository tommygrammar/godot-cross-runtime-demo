using System;
using System.Threading;
using System.Threading.Tasks;
using GodotWeb;

public static class TwoDogRunner
{
    
    public static async Task Run()
    {
        Helpers.ResetCommandBuffer();
        // Bootstrap: get the SceneTree directly (the C++ handler returns it)
        //SharedMemory.SendCommand(Commands.CMD_Engine_get_singleton__r0);
        //SharedMemory.WaitForCompletion();
        ulong sceneTreeId = Engine.get_singleton(); 
    
        Console.WriteLine($"[2dog] SceneTree ID: {sceneTreeId}");
        if (sceneTreeId == 0)
        {
            Console.WriteLine("[2dog] Failed to get SceneTree");
            return;
        }
    
        SceneTree tree = new SceneTree(sceneTreeId);
    
        // Everything below is exactly the same generated API
        ulong rootId = tree.get_root();
        if (rootId == 0)
        {
            Console.WriteLine("[2dog] get_root returned 0");
            return;
        }
    
        Node root = new Node(rootId);
    
        ulong labelId = root.find_child("TargetLabel", true, false);
        if (labelId == 0)
        {
            Console.WriteLine("[2dog] TargetLabel not found");
            return;
        }
    
        Label label = new Label(labelId);
        Console.WriteLine($"[2dog] Label found, id = {label.Id}");
        Console.WriteLine("[2dog] Entering the gaming loop");
    
        int tick = 0;
        while (true)
        {
            tick++;
            label.set_text($"2dog running - tick - my ticks {tick}");
            //await Task.Delay(16);
        }
    }
     
     /*
     public static async Task Run()
     {
         // ---------- Particle simulation setup ----------
         DotGame.Initialize();
     
         // ---------- 2dog label demo (unchanged) ----------
         ulong sceneTreeId = Engine.get_singleton();
         // … find label, etc. (your existing code)
         // SceneTree tree = new SceneTree(sceneTreeId);
     
         // Everything below is exactly the same generated API
         ulong rootId = tree.get_root();
         if (rootId == 0)
         {
             Console.WriteLine("[Dot] get_root returned 0");
             return;
         }
     
         Node root = new Node(rootId);
     
         ulong labelId = root.find_child("TargetLabel", true, false);
         if (labelId == 0)
         {
             Console.WriteLine("[Dot] TargetLabel not found");
             return;
         }
     
         Label label = new Label(labelId);
         Console.WriteLine($"[Dot] Label found, id = {label.Id}");
         Console.WriteLine("[Dot] Entering the gaming loop");
     
         int tick = 0;
         while (true)
         {
             tick++;
             label.set_text($"2dog running - tick {tick}");
             DotGame.Update(0.016f);   // physics + transform updates
             await Task.Delay(16);
         }
     }
      */
}