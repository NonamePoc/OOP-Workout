using Lab4Shaban.Lib;
using NUnit.Framework;

namespace Lab4Shaban.Test;

public class RayTests
{
    [Test]
    public void RayEqualsTest()
    {
        Ray ray1 = new Ray(1, 1, 1, 1);
        Ray ray2 = new Ray(1, 1, 1, 1);

        Assert.AreEqual(ray1, ray2);
    }

    [Test]
    public void IsRayParallelTest()
    {
        Ray ray1 = new Ray(1, 2, 1, 2);
        Ray ray2 = new Ray(1, 1, 1, 1);

        var result = Ray.IsParallel(ray1, ray2);

        Assert.IsTrue(result);
    }

    [Test]
    public void AddVertexValueTest()
    {
        Ray expectedRay = new Ray(3, 3, 1, 1);
        Ray inputRay = new Ray(1, 1, 1, 1);

        inputRay.AddVertexValue(new Point(2, 2));

        Assert.AreEqual(expectedRay, inputRay);
    }

    [Test]
    public void ConvertToJsonTest()
    {
        Ray inputRay = new Ray(1, 1, 1, 1);
        var expectedJson =
            "{\"Vector\":{\"X\":1.0,\"Y\":1.0},\"Cross0X\":false,\"Cross0Y\":false,\"Vertex\":{\"X\":1.0,\"Y\":1.0}}";

        var result = inputRay.ConvertToJson();

        Assert.AreEqual(result, expectedJson);
    }
}