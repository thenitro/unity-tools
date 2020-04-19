using NUnit.Framework;
using UnityEngine;

public class AbstractTest
{
    [TearDown]
    public void TearDown()
    {
        Cleanup();
    }

    protected virtual void Cleanup()
    {
        Contexts.sharedInstance = null;
        PlayerPrefs.DeleteAll();
    }

    protected Contexts C
    {
        get
        {
            return Contexts.sharedInstance;
        }
    }
}