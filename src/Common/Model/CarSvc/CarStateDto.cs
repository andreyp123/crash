namespace Common.Model.CarSvc;

public class CarStateDto
{
    public string? DriveState { get; set; }
    public int? Mileage { get; set; }
    public decimal? LocationLat { get; set; }
    public decimal? LocationLon { get; set; }
    public decimal? RemainingFuel { get; set; }
    public string? Alert { get; set; }
}