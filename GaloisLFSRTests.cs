namespace KMZI
{
    public class GaloisLFSRTests
    {
        public object Assert { get; private set; }

       
        public void Constructor_ValidPolynomialLength_ShouldNotThrowException()
        {
            // Arrange
            string polynomial = "11001010"; // Валиден полином с осем бита

            // Act & Assert
            Assert.DoesNotThrow(() =>
            {
                InitializeGaloisLFSR(polynomial);
            });
        }

        private void InitializeGaloisLFSR(string polynomial)
        {
            new GaloisLFSR(polynomial);
        }



        public void Constructor_InvalidPolynomialLength_ShouldThrowException()
        {
            // Arrange
            string invalidPolynomial = "1100"; // Невалиден полином с по-малко от осем бита

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new GaloisLFSR(invalidPolynomial));
        }
    }
}
