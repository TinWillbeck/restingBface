public class Character
{
    public string name { get; set; }
    public string mass { get; set; }
    public string height { get; set; }
    public string gender { get; set; }

    public int WeightInt {
        private set {}
        get {
            return int.Parse(mass);
        }
    }

    public int weightInt;
    public int heightInt;

        // int.TryParse(height, out heightInt);
//     public void getHeight()
//     {
//     }
}
