ALTER VIEW [dbo].[v_CleanedFloors] AS
SELECT 
    -- Remove commas and convert to numbers
    CAST(REPLACE([Area], ',', '') AS FLOAT) AS Area,
    CAST(REPLACE([Volume], ',', '') AS FLOAT) AS Volume,
    CAST(REPLACE([Perimeter], 'm', '') AS FLOAT) AS Perimeter,
    CAST(REPLACE([HeightOffsetFromLevel], 'm', '') AS FLOAT) AS HeightOffsetFromLevel,
    CAST(REPLACE([ElevationatTop], 'm', '') AS FLOAT) AS ElevationatTop,
    CAST(REPLACE([ElevationatBottom], 'm', '') AS FLOAT) AS ElevationatBottom,
    CAST(REPLACE([Thickness], 'm', '') AS FLOAT) AS Thickness,
    -- List all other columns you want (no changes for these)
    [RoomBounding],
    [FamilyName],
    [ElementId],
    [Level],
    [Structural],
    [Workset],
    [Editedby],
    [Slope],
    [RelatedtoMass]
    -- ...add the rest of your columns here...
FROM [dbo].[_A_KPF_CORE_detached_mscigaj_detached__mscigaj_Floors]
