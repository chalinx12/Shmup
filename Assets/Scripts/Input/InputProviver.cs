using UnityEngine;
public static class InputProviver {
    public delegate void HasShoot();
    public static event HasShoot OnhasShoot;

    public delegate void Direccion(Vector3 direccion);
    public static event Direccion OnDireccion;
    //public static InputProviver Instance;
    public static  void TriggerOnHasShoot()
    {
        OnhasShoot?.Invoke();
    }

    public static void TriggerDirection(Vector3 direccion)
    {
        OnDireccion?.Invoke(direccion);
    }
}
