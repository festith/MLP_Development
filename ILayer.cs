namespace MLP_Network
{
    public interface ILayer
    {
        /// <summary>
        /// Compute output of the layer
        /// </summary>
        /// <param name="inputVector">Input vector</param>
        /// <returns>Output vector</returns>
        float[] Compute(float[] inputVector);
    }
}
