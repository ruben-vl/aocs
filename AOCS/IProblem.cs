using System;

namespace AOCS {
    class AOCProblem(int year, int day) {
        public int Year { get; private set; } = year;
        public int Day { get; private set; } = day;

        public int SolveP1() {
            return 0;
        }

        public int SolveP2() {
            return 0;
        }
    }

    class Program {
        static void Main(string[] args) {
            int year = 0;
            int day = 0;
            AOCProblem problem = new(year, day);
            Console.WriteLine($"{year}-{day}: {problem.SolveP1()}");
            Console.WriteLine($"{year}-{day}: {problem.SolveP2()}");
        }
    }
}
