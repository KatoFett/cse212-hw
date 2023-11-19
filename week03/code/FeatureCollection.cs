public class FeatureCollection
{
    public FeatureCollectionMetadata Metadata { get; set; }
    public decimal[] BBox { get; set; }
    public Feature[] Features { get; set; }

    // Readonly properties
    public decimal MinimumLongitude => BBox[0];
    public decimal MinimumLatitude => BBox[1];
    public decimal MinimumDepth => BBox[2];
    public decimal MaximumLongitude => BBox[3];
    public decimal MaximumLatitude => BBox[4];
    public decimal MaximumDepth => BBox[5];
}

public class FeatureCollectionMetadata
{
    public long Generated { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public string Api { get; set; }
    public int Count { get; set; }
    public int Status { get; set; }
}

public class Feature
{
    public FeatureProperties Properties { get; set; }

    public FeatureGeometry Geometry { get; set; }

    public string Id { get; set; }

    public override string ToString()
    {
        return $"{Properties.Place} - Mag {Properties.Mag}";
    }
}

public class FeatureProperties
{
    public decimal Mag { get; set; }
    public string Place { get; set; }
    public long Time { get; set; }
    public long Updated { get; set; }
    public int? Tz { get; set; }
    public string Url { get; set; }
    public string Detail { get; set; }
    public int? Felt { get; set; }
    public decimal? Cdi { get; set; }
    public decimal? Mmi { get; set; }
    public string Alert { get; set; }
    public string Status { get; set; }
    public int Tsunami { get; set; }
    public int Sig { get; set; }
    public string Net { get; set; }
    public string Code { get; set; }
    public string Ids { get; set; }
    public string Sources { get; set; }
    public string Types { get; set; }
    public int? Nst { get; set; }
    public decimal? Dmin { get; set; }
    public decimal Rms { get; set; }
    public decimal? Gap { get; set; }
    public string MagType { get; set; }
    public string Type { get; set; }
}

public class FeatureGeometry
{
    public decimal[] Coordinates { get; set; }

    // Readonly properties
    public decimal Longitude => Coordinates[0];
    public decimal Latitude => Coordinates[1];
    public decimal Depth => Coordinates[2];
}