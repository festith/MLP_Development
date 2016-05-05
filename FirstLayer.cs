using System.Linq;

namespace MLP_Network
{
    public class FirstLayer : ILayer
    {
        private IFunction activationFunction;

        public FirstLayer(IFunction activationFunction)
        {
            this.activationFunction = activationFunction;
        }

        /// <summary>
        /// Compute output of the layer
        /// </summary>
        /// <param name="inputVector">Input vector</param>
        /// <returns>Output vector</returns>
        public float[] Compute(float[] inputVector)
        {
            var inputCount = inputVector.Count();
            var result = new float[inputCount];
            for (int i = 0; i < inputCount; i++)
            {
                result[i] = activationFunction.Compute(inputVector[i]);
            }

            return result;
        }
    }
}