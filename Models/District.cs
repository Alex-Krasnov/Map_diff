namespace Map_diff.Models
{
    public class District
    {
        public double District_count;
        public int District_r;
        public int District_g;
        public int District_b;

        public District(double a)
        {
            District_count = a;
        }
        
        public District(int b, int c, int d)
        {
            District_r = b;
            District_g = c;
            District_b = d;
        }
    }
}
