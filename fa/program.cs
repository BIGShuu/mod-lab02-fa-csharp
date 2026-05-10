using System;
using System.Collections.Generic;
using System.Linq;

namespace fans
{
    public class State
    {
        public string Name;
        public Dictionary<char, State> Transitions;
        public bool IsAcceptState;
        public State() => Transitions = new Dictionary<char, State>();
    }

    // ЗАДАЧА 1: ровно один '0' и хотя бы одна '1'
    public class FA1
    {
        private readonly State q0, q1, q2, q3, q4;

        public FA1()
        {
            q0 = new State { Name = "q0", IsAcceptState = false };
            q1 = new State { Name = "q1", IsAcceptState = false };
            q2 = new State { Name = "q2", IsAcceptState = false };
            q3 = new State { Name = "q3", IsAcceptState = true };
            q4 = new State { Name = "q4", IsAcceptState = false };

            q0.Transitions['0'] = q2;
            q0.Transitions['1'] = q1;
            q1.Transitions['0'] = q3;
            q1.Transitions['1'] = q1;
            q2.Transitions['0'] = q4;
            q2.Transitions['1'] = q3;
            q3.Transitions['0'] = q4;
            q3.Transitions['1'] = q3;
            q4.Transitions['0'] = q4;
            q4.Transitions['1'] = q4;
        }

        public bool? Run(IEnumerable<char> s)
        {
            var current = q0;
            foreach (var c in s)
            {
                if (!current.Transitions.ContainsKey(c)) return null;
                current = current.Transitions[c];
            }
            return current.IsAcceptState;
        }
    }

    // ЗАДАЧА 2: нечётное кол-во '0' И нечётное кол-во '1'
    public class FA2
    {
        private readonly State q00, q01, q10, q11;

        public FA2()
        {
            q00 = new State { Name = "q00", IsAcceptState = false };
            q01 = new State { Name = "q01", IsAcceptState = false };
            q10 = new State { Name = "q10", IsAcceptState = false };
            q11 = new State { Name = "q11", IsAcceptState = true };

            q00.Transitions['0'] = q10;
            q00.Transitions['1'] = q01;
            q01.Transitions['0'] = q11;
            q01.Transitions['1'] = q00;
            q10.Transitions['0'] = q00;
            q10.Transitions['1'] = q11;
            q11.Transitions['0'] = q01;
            q11.Transitions['1'] = q10;
        }

        public bool? Run(IEnumerable<char> s)
        {
            var current = q00;
            foreach (var c in s)
            {
                if (!current.Transitions.ContainsKey(c)) return null;
                current = current.Transitions[c];
            }
            return current.IsAcceptState;
        }
    }

    // ЗАДАЧА 3: содержит подстроку "11"
    public class FA3
    {
        private readonly State q0, q1, q2;

        public FA3()
        {
            q0 = new State { Name = "q0", IsAcceptState = false };
            q1 = new State { Name = "q1", IsAcceptState = false };
            q2 = new State { Name = "q2", IsAcceptState = true };

            q0.Transitions['0'] = q0;
            q0.Transitions['1'] = q1;
            q1.Transitions['0'] = q0;
            q1.Transitions['1'] = q2;
            q2.Transitions['0'] = q2;
            q2.Transitions['1'] = q2;
        }

        public bool? Run(IEnumerable<char> s)
        {
            var current = q0;
            foreach (var c in s)
            {
                if (!current.Transitions.ContainsKey(c)) return null;
                current = current.Transitions[c];
            }
            return current.IsAcceptState;
        }
    }
}
