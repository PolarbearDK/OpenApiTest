namespace OpenApiTest
{
    public enum Supported
    { 
        No = 0,
        Yes
    }

    public class BreakOpenApiModel
    {
        /// <summary>
        /// This field breaks Open API clients when JsonLibrary is System.Text.Json" />
        /// </summary>
        public Supported System { get; set; }
        /// <summary>
        /// This field breaks Open API clients when JsonLibrary is Newtonsoft.Json" />
        /// </summary>
        public Supported Newtonsoft { get; set; }
    }
}