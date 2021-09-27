using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManagement : MonoBehaviour, IPointerEnterHandler
{

    // Start is called before the first frame update
    void Start()
    {
        //cursorTexture = (Texture2D)Resources.Load("images/hand_cursor_texture.png");
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => { OnPointerEnter((PointerEventData)data); });
        EventTrigger.Entry entryPointerExit = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerExit;
        entry.callback.AddListener((data) => { OnPointerExit((PointerEventData)data); });
        trigger.triggers.Add(entry);
        trigger.triggers.Add(entryPointerExit);
    }

    [DllImport("user32.dll", EntryPoint = "SetCursor")]
    public static extern IntPtr SetCursor(IntPtr hCursor);

    [DllImport("user32.dll", EntryPoint = "LoadCursor")]
    public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

    [DllImport("user32.dll", EntryPoint = "SetClassLongPtrA")]
    public static extern IntPtr SetCursorClass(HandleRef hInstance, int index, IntPtr newLong);

    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    public static IntPtr GetWindowHandle()
    {
        return GetActiveWindow();
    }

    public void OnPointerEnter(PointerEventData pointerData)
    {
        SetCursorClass(new HandleRef(null, GetWindowHandle()), -12, LoadCursor(IntPtr.Zero, 32649));
    }

    public void OnPointerExit(PointerEventData pointerData)
    {
        SetCursorClass(new HandleRef(null, GetWindowHandle()), -12, LoadCursor(IntPtr.Zero, 32512));
    }


    private void Update()
    {
    }

}
