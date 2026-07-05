public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var n = position.Length;
        if(n <= 1) return n;

        var car = new (int Position, int Speed)[n];
        for(int i = 0; i < n; i++) car[i] = new (position[i], speed[i]);
        Array.Sort(car, (a,b) => b.Position.CompareTo(a.Position));

        int fleets = 0;
        double previousTime = 0.0;
        for(int i = 0; i < n; i++){
            double timeToTarget = ((double)target - car[i].Position) / car[i].Speed;
            if(timeToTarget > previousTime){
                fleets++;
                previousTime = timeToTarget;
            }
        }

        return fleets;
    }
}
