namespace CodeChallenges.Codility
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            var answers = new int [P.Length];
            var A = new int[S.Length];
            var C = new int[S.Length];
            var G = new int[S.Length];
            var T = new int[S.Length];

            for (var i = 0; i < S.Length; i++)
            {
                var nucleotid = S[i];
                WriteLastSeenNucleotid(A, nucleotid, i, 'A');
                WriteLastSeenNucleotid(C, nucleotid, i, 'C');
                WriteLastSeenNucleotid(G, nucleotid, i, 'G');
                WriteLastSeenNucleotid(T, nucleotid, i, 'T');
            }

            for (var i = 0; i < P.Length; i++)
            {
                if (CheckLastSeen(P, Q, A, i, answers, 1))
                {
                }
                else if (CheckLastSeen(P, Q, C, i, answers, 2))
                {
                }
                else if (CheckLastSeen(P, Q, G, i, answers, 3))
                {
                }
                else
                {
                    CheckLastSeen(P, Q, T, i, answers, 4);
                }
            }

            return answers;
        }

        private static bool CheckLastSeen(int[] P, int[] Q, int[] lastSeen, int i, int[] answers, int factor)
        {
            if (lastSeen[Q[i] + 1] >= P[i])
            {
                answers[i] = factor;
                return true;
            }

            return false;
        }

        private void WriteLastSeenNucleotid(int[] lastSeen, char nucleotid, int i1, char dna)
        {
            if (nucleotid == dna)
            {
                lastSeen[i1] = i1;
            }
            else
            {
                if (i1 != 0)
                {
                    lastSeen[i1] = lastSeen[i1 - 1];
                }
            }
        }
    }
}