using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTest
{
    // Test Default
    [Test]
    public void CubeDefaultTest()
    {
        // Initialize
        Cube testCube = new Cube();

        // Assert
        Assert.AreEqual(0, testCube.getHeight());
        Assert.AreEqual(0, testCube.getWidth());
        Assert.AreEqual(0, testCube.getLength());
        Assert.AreEqual(0, testCube.getVolume());
    }

    // Test 2x3x4
    [Test]
    public void CubeTwoByThreeByFourTest()
    {
        // Initialize
        Cube testSetCube = new Cube(2f, 3f, 4f);

        //Assert
        Assert.AreEqual(2, testSetCube.getHeight());
        Assert.AreEqual(3, testSetCube.getWidth());
        Assert.AreEqual(4, testSetCube.getLength());
        Assert.AreEqual(24, testSetCube.getVolume());
        Assert.AreEqual(4, testSetCube.getEdge());
    }

    // Test Set Height
    [Test]
    public void CubeHeightTest()
    {
        //Initialize
        Cube testHeight = new Cube(1f, 3f, 8f);

        //Act
        testHeight.setHeight(5);

        //Assert
        Assert.AreEqual(5, testHeight.getHeight()); // Main Assertion
        Assert.AreEqual(3, testHeight.getWidth());
        Assert.AreEqual(8, testHeight.getLength());
        Assert.AreEqual(120, testHeight.getVolume());
        Assert.AreEqual(8, testHeight.getEdge());
    }

    // Test Set Length
    [Test]
    public void CubeLengthTest()
    {
        //Initialize
        Cube testLength = new Cube(5f, 6f, 1f);

        //Act
        testLength.setLength(3);

        //Assert
        Assert.AreEqual(5, testLength.getHeight()); 
        Assert.AreEqual(6, testLength.getWidth());
        Assert.AreEqual(3, testLength.getLength()); // Main Assertion
        Assert.AreEqual(90, testLength.getVolume());
        Assert.AreEqual(3, testLength.getEdge());
    }

    // Test set Width
    [Test]
    public void CubeWidthTest()
    {
        //Initialize
        Cube testWidth = new Cube(8f, 1f, 4f);

        //Act
        testWidth.setWidth(6);

        //Assert
        Assert.AreEqual(8, testWidth.getHeight());
        Assert.AreEqual(6, testWidth.getWidth()); // Main Assertion
        Assert.AreEqual(4, testWidth.getLength());
        Assert.AreEqual(192, testWidth.getVolume());
        Assert.AreEqual(4, testWidth.getEdge());
    }
}
