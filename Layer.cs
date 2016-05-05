using System.Linq;

namespace MLP_Network
{
    public class Layer : ILayer
    {
        /// <summary>
        /// Get neurons of the layer
        /// </summary>
        public Neuron[] Neurons { get; private set; }

        public Layer(IFunction activationFunction, int inputDimension, int neuronsCount)
        {
            Neurons = new Neuron[neuronsCount];
            
            for (int i = 0; i < neuronsCount; i++)
            {
                Neurons[i] = new Neuron(activationFunction, inputDimension);
            }
        }

        /// <summary>
        /// Compute output of the layer
        /// </summary>
        /// <param name="inputVector">Input vector</param>
        /// <returns>Output vector</returns>
        public float[] Compute(float[] inputVector)
        {
            var result = new float[Neurons.Count()];
            for (int i = 0; i < Neurons.Count(); i++)
            {
                result[i] = Neurons[i].Activate(inputVector);
            }

            return result;
        }
    }
}