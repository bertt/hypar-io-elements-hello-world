using Elements.Serialization.IFC;
using Elements.Serialization.glTF;
using System;

namespace hypar_io_elements_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var newModel = IFCModelExtensions.FromIFC("AC-20-Smiley-West-10-Bldg.ifc");
            newModel.ToGlTF("test.glb");
        }
    }
}
