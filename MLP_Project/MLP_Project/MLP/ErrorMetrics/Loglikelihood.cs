using System;

namespace MLP_Network
{
    internal class Loglikelihood : IMetrics
    {
        public float Calculate(float[] v1, float[] v2)
        {
            float d = 0f;
            for (int i = 0; i < v1.Length; i++)
            {
                d += v1[i] * (float)Math.Log(v2[i]) + (1 - v1[i]) * (float)Math.Log(1 - v2[i]);
            }

            return -d;
        }

        public float CalculatePartialDerivaitveByV2Index(float[] v1, float[] v2, int v2Index)
        {
            if ((Math.Abs(v2[v2Index] - 1f) > 0.001f) && (Math.Abs(v2[v2Index]) > 0.001f))
            {
                return -(v1[v2Index] / v2[v2Index] - (1 - v1[v2Index]) / (1 - v2[v2Index]));
            }

            return 0;
        }
    }
}
