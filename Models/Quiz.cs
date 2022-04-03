namespace WebApplication1.Models
{
    public class Quiz
    {      
        public int x { get; set; }
        public int y { get; set; }         
        public char sign { get; set; }
        public int res { get; set; }

        public Random rand = new Random();       
        public int signID;

        public Quiz()
        {
            x = rand.Next(0, 10); y = rand.Next(0, 10); signID = rand.Next(0, 4);
            if (signID == 0) { sign = '+';  res = (x + y); }
            else if (signID == 1) { sign = '-'; res = (x - y); }
            else if (signID == 2) { sign = '*'; res = (x * y); }
            else {
                if (y == 0) y++;
                sign = '/'; res = (x / y); 
            }                     
        }    
    }
}
