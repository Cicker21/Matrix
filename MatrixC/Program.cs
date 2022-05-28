

    class Program
    {

        static int Counter;
        static Random randomPosition = new Random();


    static void Main2() {
        
        for (int i = 0; i < 10000; i++)
        {
            char a = (char)('0' + i);
            char b = (char)('a' + i);
            char c = (char)('A' + i);
            if(a.ToString() != "?") { Console.Write(a); }
            if (b.ToString() != "?") { Console.Write(b); }
            if (c.ToString() != "?") { Console.Write(c); }

        }
    }

        static int flowSpeed = 100;
        static int fastFlow = flowSpeed + 30;
        static int textFlow = flowSpeed + 500;

        static ConsoleColor basecolor = ConsoleColor.DarkGreen;
        static ConsoleColor greencolor = ConsoleColor.Green;
        static ConsoleColor fadedcolor = ConsoleColor.White;

        static String endText = "Cicker";

        static char Asciicharacters
        {
            get
            {
            int stress = 500; //0-10000 
                int t = randomPosition.Next(10);
            if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)('a' + randomPosition.Next(stress));
                else if (t <= 6) return (char)('A' + randomPosition.Next(stress));
                else return (char)(randomPosition.Next(32, stress));

            }

        }
        static void Main()
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = basecolor;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;

            int width, height;
            int[] y;
            Initialize(out width, out height, out y);

            while (true)
            {

                Counter++;
                ColumnUpdate(width, height, y);
                if (Counter > (3 * flowSpeed))
                    Counter = 0;
            }
        }

        public static int YPositionFields(int yPosition, int height)
        {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;

        }

        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();

            for (int x = 0; x < width; ++x) { y[x] += randomPosition.Next(height); }
        }

        private static void ColumnUpdate(int width, int height, int[] y)
        {
            int x;
            if (Counter < flowSpeed)
            {
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == 1) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(Asciicharacters);

                    if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    int temp = y[x] - 2;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(Asciicharacters);

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            /*else if (Counter > flowSpeed && Counter < textFlow)
            {
                for (x = 0; x < width; ++x)
                {
                    Console.SetCursorPosition(x, y[x]);
                    if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                    else Console.ForegroundColor = basecolor;

                    Console.Write(Asciicharacters);

                    y[x] = YPositionFields(y[x] + 1, height);

                }
            }*/
            else if (Counter > fastFlow)
            {
                for (x = 0; x < width; ++x)
                {
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(' ');

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');

                    if (Counter > fastFlow && Counter < textFlow)
                    {
                        if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                        else Console.ForegroundColor = basecolor;

                        int temp = y[x] - 2;
                        Console.SetCursorPosition(x, YPositionFields(temp, height));
                        Console.Write(Asciicharacters);

                    }
                    Console.SetCursorPosition(width / 2, height / 2);
                    Console.Write(endText);
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
        }
    }
