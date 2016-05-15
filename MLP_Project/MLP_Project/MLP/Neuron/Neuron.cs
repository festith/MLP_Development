﻿using System;

namespace MLP_Network
{
    public class Neuron
    {
        /// <summary>
        /// Weights of the neuron (income signal)
        /// </summary>
        public float[] Weights { get; set; }

        private static Random random = new Random();
        private IFunction activationFunction;
        private HebbMethod learningMethod;
        private bool isLearningMethodActivated;

        public Neuron(IFunction activationFunction, int inputDimension)
        {
            Weights = new float[inputDimension];
            InitializeWeights();

            this.activationFunction = activationFunction;
        }

        public void ActivateLearningMethod(HebbMethod method)
        {
            learningMethod = method;
            isLearningMethodActivated = true;
        }
        private void InitializeWeights()
        {
            for (int i = 0; i < Weights.Length; i++)
            {
                Weights[i] = random.Next(-50, 50)/50f;
            }
        }

        /// <summary>
        /// Compute state of neuron
        /// </summary>
        /// <param name="inputVector">Input vector (must be the same dimension as Weights )</param>
        /// <returns>State of neuron</returns>
        public float Activate(float[] inputVector)
        {
            var input = 0f;
            for (int i = 0; i < Weights.Length; i++)
            {
                input += inputVector[i]*Weights[i];
            }

            var result = activationFunction.Compute(input);

            if (isLearningMethodActivated)
            {
                for (int i = 0; i < Weights.Length; i++)
                {
                    Weights[i] = learningMethod.CalculateWeight(Weights[i], inputVector[i], result);
                }
            }

            return result;
        }
    }
}