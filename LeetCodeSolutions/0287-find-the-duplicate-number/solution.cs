public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0; int fast = 0;
        
        // Phase 1: Detect cycle and find an intersection point
        do {
           slow = nums[slow];           // Move 1 step
            fast = nums[nums[fast]];     // Move 2 steps
        } while (slow != fast);

        // Phase 2: Math proves Distance(Start -> Door) == Distance(Intersection -> Door)
        slow = 0; // Reset one pointer to the start
    
        // Move both at the same speed (1 step) until they collide at the door
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[fast];
        }

        // The collision point is the cycle entrance "door" (the duplicate number)
        return slow;
    }
}
