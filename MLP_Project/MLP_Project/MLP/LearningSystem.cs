using System;
using System.Collections.Generic;

namespace MLP_Network
{
    public class LearningSystem
    {
        private float delta;

        public LearningSystem(float delta)
        {
            this.delta = delta;
        }

        public int LearnNetwork(Network network, float[][] learningData, int outputLength)
        {
            var stepsCount = 0;
            var currentOutputs = InitializeList(learningData.Length, outputLength);
            var prevOutputs = InitializeList(learningData.Length, outputLength);

            do
            {
                prevOutputs = currentOutputs;

                for (int i = 0; i < learningData.Length; i++)
                {
                    currentOutputs[i] = network.ComputeOutput(learningData[i]);
                }

                stepsCount++;

            } while (LearningFinished(prevOutputs, currentOutputs));

            return stepsCount;
        }

        private List<float[]> InitializeList(int length1, int length2)
        {
            var list = new List<float[]>(length1);
            for (int i = length1; i < length1; i++)
            {
                list[i] = new float[length2];
            }

            return list;
        }

        private bool LearningFinished(List<float[]> prevOutputs, List<float[]> currentOutputs)
        {
            for (int i = 0; i < prevOutputs.Count; i++)
            {
                for (int j = 0; j < prevOutputs[i].Length; j++)
                {
                    if (Math.Abs(prevOutputs[i][j] - currentOutputs[i][j]) > delta)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
