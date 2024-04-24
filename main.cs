public class Solution {
    public int MaxArea(int[] height) 
    {
        int i = 0;
        int j = height.Length -1;
        int water = 0;
        while(i < j)
        {
            water = Math.Max(water, Math.Abs(i - j)*Math.Min(height[i],height[j]));
            if(height[i] < height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return water;    
    }
}
