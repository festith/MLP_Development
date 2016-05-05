namespace MLP_Network
{
    public class Neuron
    {
        /// <summary>
        /// Weights of the neuron (income signal)
        /// </summary>
        public float[] Weights { get; set; }

        private IFunction activationFunction;

        public Neuron(IFunction activationFunction, int inputDimension)
        {
            Weights = new float[inputDimension];
            this.activationFunction = activationFunction;
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

            return activationFunction.Compute(input);
        }
    }
}