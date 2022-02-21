using System;

namespace ladder
{
    class boards
    {
        public int count;
        public double length;
        double weight = 0.15;
    }

    class Program
    {
        static void Main(string[] args)
        {
            boards board_3m = new boards();
            boards board_2m = new boards();
            boards board_4m = new boards();

            board_3m.count = 15;
            board_2m.count = 4;
            board_4m.count = 4;

            board_3m.length = 3.00;
            board_2m.length = 2.00;
            board_4m.length = 4.00;


            int count = 0;

            for (int i = 0; i < 2; i++)
            {
                while (i != i + 1)

                {
                    
                    count = 2 + count;

                }


                        }


            System. "Первая ступень состоит из 4 досок ";

        }
    }
}
