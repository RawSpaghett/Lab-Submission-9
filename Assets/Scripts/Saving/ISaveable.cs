using UnityEngine;

public interface ISaveable
{
    public abstract object CaptureState();

    public abstract void LoadState(object saveData);


}
