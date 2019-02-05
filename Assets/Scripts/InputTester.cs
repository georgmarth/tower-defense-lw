using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Input;

public class InputTester : MonoBehaviour //IGeneralActions
{

    public InputActions controls;

    //public void OnAltClick(InputAction.CallbackContext context)
    //{
    //    Debug.Log("Right Click!");
    //}

    //public void OnClick(InputAction.CallbackContext context)
    //{
    //    Debug.Log("LeftClick!");
    //}

    //public void OnPoint(InputAction.CallbackContext context)
    //{
    //    var value = context.ReadValue<Vector2>();
    //    Debug.Log("Mouse position: " + value);
    //}

    //public void OnTestAction(InputAction.CallbackContext context)
    //{
    //    Debug.Log("SPACE!!!");
    //}

    // Start is called before the first frame update
    void Awake()
    {
        //controls.General.SetCallbacks(this);
        //controls.General.ClickStarted += ActionPerformed;
    }

    private void OnEnable()
    {
        controls.General.Enable();
    }

    private void OnDisable()
    {
        controls.General.Disable();
    }

    private void Start()
    {
        //Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void ActionPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Test");
    }

    public void PlottableClicked(BaseEventData data)
    {
        Debug.Log("Plot clicked");
    }

}
