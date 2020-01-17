using System;

namespace CodeChallenges.Codility
{
    public class GenomicRangeQuery
    {
        private readonly int A = 0;
        private readonly int C = 1;
        private readonly int G = 2;
        private readonly int T = 3;

        public int[] solution(string S, int[] P, int[] Q)
        {
            var answers = new int[P.Length];

            var lastSeen = new int[4, S.Length + 1];

            for (var nucleotidesPosition = 0; nucleotidesPosition < S.Length; nucleotidesPosition++)
            {
                var nucleotide = S[nucleotidesPosition];

                CopyLastSeenPositionsFrompreviousStep(lastSeen, nucleotidesPosition);

                var index = GetIndexFromNucleotide(nucleotide);

                lastSeen[index, nucleotidesPosition + 1] = nucleotidesPosition + 1;
            }

            for (var query = 0; query < P.Length; query++)
            {
                var startPositionInLastSeen = P[query] + 1;
                var endPositionInLastSeen = Q[query] + 1;
                if (P[query] == Q[query])
                {
                    if (lastSeen[A, startPositionInLastSeen] != lastSeen[A, startPositionInLastSeen - 1])
                    {
                        answers[query] = 1;
                    }
                    else if (lastSeen[C, startPositionInLastSeen] != lastSeen[C, startPositionInLastSeen - 1])
                    {
                        answers[query] = 2;
                    }
                    else if (lastSeen[G, startPositionInLastSeen] != lastSeen[G, startPositionInLastSeen - 1])
                    {
                        answers[query] = 3;
                    }
                    else
                    {
                        answers[query] = 4;
                    }
                }
                else
                {
                    if (lastSeen[A, endPositionInLastSeen] >= startPositionInLastSeen)
                    {
                        answers[query] = 1;
                    }
                    else if (lastSeen[C, endPositionInLastSeen] >= startPositionInLastSeen)
                    {
                        answers[query] = 2;
                    }
                    else if (lastSeen[G, endPositionInLastSeen] >= startPositionInLastSeen)
                    {
                        answers[query] = 3;
                    }
                    else
                    {
                        answers[query] = 4;
                    }
                }
            }


            return answers;
        }

        private void CopyLastSeenPositionsFrompreviousStep(int[,] lastSeen, int nucleotidesPosition)
        {
            if (nucleotidesPosition == 0)
            {
                return;
            }

            for (var i = 0; i < 4; i++)
            {
                var previousLastSeen = lastSeen[i, nucleotidesPosition];
                lastSeen[i, nucleotidesPosition + 1] = previousLastSeen;
            }
        }

        private int GetIndexFromNucleotide(char nucleotide)
        {
            switch (nucleotide)
            {
                case 'A': return A;
                case 'C': return C;
                case 'G': return G;
                case 'T': return T;
                default:
                    throw new InvalidOperationException("Bad thing happened");
            }
        }
    }
}