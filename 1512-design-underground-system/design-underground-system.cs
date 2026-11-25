public class UndergroundSystem {

    public UndergroundSystem() {
        
    }

    Dictionary< int , (string Start, int CheckInTime)> checkIns = new();    
    Dictionary<(string , string) , (double Total ,int Count)> checkOuts = new();    
    public void CheckIn(int id, string stationName, int t) {
    
        checkIns[id] = (stationName,t); 
    }   
    
    public void CheckOut(int id, string stationName, int t)
    {
        var value = checkIns[id];

        if (checkOuts.TryGetValue((value.Start, stationName), out var y))
        {
            checkOuts[(value.Start, stationName)] =
                (y.Total + (t - value.CheckInTime), y.Count + 1);
        }
        else
        {
            checkOuts[(value.Start, stationName)] = (t - value.CheckInTime, 1);
        }

        checkIns.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) {

     var cValue = checkOuts[(startStation,endStation)];
     
     double avgTime = cValue.Total/cValue.Count;
     return avgTime;
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */