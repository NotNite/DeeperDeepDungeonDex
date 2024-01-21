﻿using FFXIVClientStructs.FFXIV.Common.Math;

namespace DeeperDeepDungeonDex.System;

public class FloorDataWindow : DeepDungeonWindow {
    private readonly IDrawableFloorSet floorSet;

    public FloorDataWindow(string windowName, IDrawableFloorSet floorData) : base(windowName) {
        floorSet = floorData;
        
        SizeConstraints = new WindowSizeConstraints {
            MinimumSize = new Vector2(350.0f, 350.0f),
            MaximumSize = new Vector2(float.PositiveInfinity),
        };
    }

    public override bool DrawConditions() {
        if (!Plugin.InDeepDungeon()) return false;
        if (!Plugin.Configuration.EnableFloorWindow) return false;

        return true;
    }

    public override void Draw() {
        base.Draw();
        
        floorSet.Draw();
    }
}
