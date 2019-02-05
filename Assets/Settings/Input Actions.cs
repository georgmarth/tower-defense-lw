// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input Actions.inputactions'

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;


[Serializable]
public class InputActions : InputActionAssetReference
{
    public InputActions()
    {
    }
    public InputActions(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // General
        m_General = asset.GetActionMap("General");
        m_General_Point = m_General.GetAction("Point");
        if (m_GeneralPointActionStarted != null)
            m_General_Point.started += m_GeneralPointActionStarted.Invoke;
        if (m_GeneralPointActionPerformed != null)
            m_General_Point.performed += m_GeneralPointActionPerformed.Invoke;
        if (m_GeneralPointActionCancelled != null)
            m_General_Point.cancelled += m_GeneralPointActionCancelled.Invoke;
        m_General_Click = m_General.GetAction("Click");
        if (m_GeneralClickActionStarted != null)
            m_General_Click.started += m_GeneralClickActionStarted.Invoke;
        if (m_GeneralClickActionPerformed != null)
            m_General_Click.performed += m_GeneralClickActionPerformed.Invoke;
        if (m_GeneralClickActionCancelled != null)
            m_General_Click.cancelled += m_GeneralClickActionCancelled.Invoke;
        m_General_AltClick = m_General.GetAction("AltClick");
        if (m_GeneralAltClickActionStarted != null)
            m_General_AltClick.started += m_GeneralAltClickActionStarted.Invoke;
        if (m_GeneralAltClickActionPerformed != null)
            m_General_AltClick.performed += m_GeneralAltClickActionPerformed.Invoke;
        if (m_GeneralAltClickActionCancelled != null)
            m_General_AltClick.cancelled += m_GeneralAltClickActionCancelled.Invoke;
        m_General_TestAction = m_General.GetAction("TestAction");
        if (m_GeneralTestActionActionStarted != null)
            m_General_TestAction.started += m_GeneralTestActionActionStarted.Invoke;
        if (m_GeneralTestActionActionPerformed != null)
            m_General_TestAction.performed += m_GeneralTestActionActionPerformed.Invoke;
        if (m_GeneralTestActionActionCancelled != null)
            m_General_TestAction.cancelled += m_GeneralTestActionActionCancelled.Invoke;
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        if (m_GeneralActionsCallbackInterface != null)
        {
            General.SetCallbacks(null);
        }
        m_General = null;
        m_General_Point = null;
        if (m_GeneralPointActionStarted != null)
            m_General_Point.started -= m_GeneralPointActionStarted.Invoke;
        if (m_GeneralPointActionPerformed != null)
            m_General_Point.performed -= m_GeneralPointActionPerformed.Invoke;
        if (m_GeneralPointActionCancelled != null)
            m_General_Point.cancelled -= m_GeneralPointActionCancelled.Invoke;
        m_General_Click = null;
        if (m_GeneralClickActionStarted != null)
            m_General_Click.started -= m_GeneralClickActionStarted.Invoke;
        if (m_GeneralClickActionPerformed != null)
            m_General_Click.performed -= m_GeneralClickActionPerformed.Invoke;
        if (m_GeneralClickActionCancelled != null)
            m_General_Click.cancelled -= m_GeneralClickActionCancelled.Invoke;
        m_General_AltClick = null;
        if (m_GeneralAltClickActionStarted != null)
            m_General_AltClick.started -= m_GeneralAltClickActionStarted.Invoke;
        if (m_GeneralAltClickActionPerformed != null)
            m_General_AltClick.performed -= m_GeneralAltClickActionPerformed.Invoke;
        if (m_GeneralAltClickActionCancelled != null)
            m_General_AltClick.cancelled -= m_GeneralAltClickActionCancelled.Invoke;
        m_General_TestAction = null;
        if (m_GeneralTestActionActionStarted != null)
            m_General_TestAction.started -= m_GeneralTestActionActionStarted.Invoke;
        if (m_GeneralTestActionActionPerformed != null)
            m_General_TestAction.performed -= m_GeneralTestActionActionPerformed.Invoke;
        if (m_GeneralTestActionActionCancelled != null)
            m_General_TestAction.cancelled -= m_GeneralTestActionActionCancelled.Invoke;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var GeneralCallbacks = m_GeneralActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        General.SetCallbacks(GeneralCallbacks);
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // General
    private InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private InputAction m_General_Point;
    [SerializeField] private ActionEvent m_GeneralPointActionStarted;
    [SerializeField] private ActionEvent m_GeneralPointActionPerformed;
    [SerializeField] private ActionEvent m_GeneralPointActionCancelled;
    private InputAction m_General_Click;
    [SerializeField] private ActionEvent m_GeneralClickActionStarted;
    [SerializeField] private ActionEvent m_GeneralClickActionPerformed;
    [SerializeField] private ActionEvent m_GeneralClickActionCancelled;
    private InputAction m_General_AltClick;
    [SerializeField] private ActionEvent m_GeneralAltClickActionStarted;
    [SerializeField] private ActionEvent m_GeneralAltClickActionPerformed;
    [SerializeField] private ActionEvent m_GeneralAltClickActionCancelled;
    private InputAction m_General_TestAction;
    [SerializeField] private ActionEvent m_GeneralTestActionActionStarted;
    [SerializeField] private ActionEvent m_GeneralTestActionActionPerformed;
    [SerializeField] private ActionEvent m_GeneralTestActionActionCancelled;
    public struct GeneralActions
    {
        private InputActions m_Wrapper;
        public GeneralActions(InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point { get { return m_Wrapper.m_General_Point; } }
        public ActionEvent PointStarted { get { return m_Wrapper.m_GeneralPointActionStarted; } }
        public ActionEvent PointPerformed { get { return m_Wrapper.m_GeneralPointActionPerformed; } }
        public ActionEvent PointCancelled { get { return m_Wrapper.m_GeneralPointActionCancelled; } }
        public InputAction @Click { get { return m_Wrapper.m_General_Click; } }
        public ActionEvent ClickStarted { get { return m_Wrapper.m_GeneralClickActionStarted; } }
        public ActionEvent ClickPerformed { get { return m_Wrapper.m_GeneralClickActionPerformed; } }
        public ActionEvent ClickCancelled { get { return m_Wrapper.m_GeneralClickActionCancelled; } }
        public InputAction @AltClick { get { return m_Wrapper.m_General_AltClick; } }
        public ActionEvent AltClickStarted { get { return m_Wrapper.m_GeneralAltClickActionStarted; } }
        public ActionEvent AltClickPerformed { get { return m_Wrapper.m_GeneralAltClickActionPerformed; } }
        public ActionEvent AltClickCancelled { get { return m_Wrapper.m_GeneralAltClickActionCancelled; } }
        public InputAction @TestAction { get { return m_Wrapper.m_General_TestAction; } }
        public ActionEvent TestActionStarted { get { return m_Wrapper.m_GeneralTestActionActionStarted; } }
        public ActionEvent TestActionPerformed { get { return m_Wrapper.m_GeneralTestActionActionPerformed; } }
        public ActionEvent TestActionCancelled { get { return m_Wrapper.m_GeneralTestActionActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                Point.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPoint;
                Point.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPoint;
                Point.cancelled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPoint;
                Click.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnClick;
                Click.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnClick;
                Click.cancelled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnClick;
                AltClick.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnAltClick;
                AltClick.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnAltClick;
                AltClick.cancelled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnAltClick;
                TestAction.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnTestAction;
                TestAction.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnTestAction;
                TestAction.cancelled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnTestAction;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                Point.started += instance.OnPoint;
                Point.performed += instance.OnPoint;
                Point.cancelled += instance.OnPoint;
                Click.started += instance.OnClick;
                Click.performed += instance.OnClick;
                Click.cancelled += instance.OnClick;
                AltClick.started += instance.OnAltClick;
                AltClick.performed += instance.OnAltClick;
                AltClick.cancelled += instance.OnAltClick;
                TestAction.started += instance.OnTestAction;
                TestAction.performed += instance.OnTestAction;
                TestAction.cancelled += instance.OnTestAction;
            }
        }
    }
    public GeneralActions @General
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GeneralActions(this);
        }
    }
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get

        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.GetControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    [Serializable]
    public class ActionEvent : UnityEvent<InputAction.CallbackContext>
    {
    }
}
public interface IGeneralActions
{
    void OnPoint(InputAction.CallbackContext context);
    void OnClick(InputAction.CallbackContext context);
    void OnAltClick(InputAction.CallbackContext context);
    void OnTestAction(InputAction.CallbackContext context);
}
