//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Effekseer.swig {

public class GUIManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GUIManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GUIManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GUIManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EffekseerNativePINVOKE.delete_GUIManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GUIManager() : this(EffekseerNativePINVOKE.new_GUIManager(), true) {
  }

  public bool Initialize(string title, int width, int height, bool isSRGBMode) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Initialize(swigCPtr, title, width, height, isSRGBMode);
    return ret;
  }

  public void Terminate() {
    EffekseerNativePINVOKE.GUIManager_Terminate(swigCPtr);
  }

  public bool DoEvents() {
    bool ret = EffekseerNativePINVOKE.GUIManager_DoEvents(swigCPtr);
    return ret;
  }

  public void Present() {
    EffekseerNativePINVOKE.GUIManager_Present(swigCPtr);
  }

  public void ResetGUI() {
    EffekseerNativePINVOKE.GUIManager_ResetGUI(swigCPtr);
  }

  public void RenderGUI() {
    EffekseerNativePINVOKE.GUIManager_RenderGUI(swigCPtr);
  }

  public System.IntPtr GetNativeHandle() { return EffekseerNativePINVOKE.GUIManager_GetNativeHandle(swigCPtr); }

  public bool Begin(string name, bool[] p_open) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Begin(swigCPtr, name, p_open);
    return ret;
  }

  public void End() {
    EffekseerNativePINVOKE.GUIManager_End(swigCPtr);
  }

  public void SetNextWindowSize(float size_x, float size_y, Cond cond) {
    EffekseerNativePINVOKE.GUIManager_SetNextWindowSize(swigCPtr, size_x, size_y, (int)cond);
  }

  public void PushItemWidth(float item_width) {
    EffekseerNativePINVOKE.GUIManager_PushItemWidth(swigCPtr, item_width);
  }

  public void PopItemWidth() {
    EffekseerNativePINVOKE.GUIManager_PopItemWidth(swigCPtr);
  }

  public void Separator() {
    EffekseerNativePINVOKE.GUIManager_Separator(swigCPtr);
  }

  public void SameLine() {
    EffekseerNativePINVOKE.GUIManager_SameLine(swigCPtr);
  }

  public void Text(string text) {
    EffekseerNativePINVOKE.GUIManager_Text(swigCPtr, text);
  }

  public void TextWrapped(string text) {
    EffekseerNativePINVOKE.GUIManager_TextWrapped(swigCPtr, text);
  }

  public bool Button(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Button(swigCPtr, label);
    return ret;
  }

  public void Image(ImageResource user_texture_id, float x, float y) {
    EffekseerNativePINVOKE.GUIManager_Image(swigCPtr, ImageResource.getCPtr(user_texture_id), x, y);
  }

  public bool Checkbox(string label, bool[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Checkbox(swigCPtr, label, v);
    return ret;
  }

  public bool InputInt(string label, int[] v, int step, int step_fast) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_0(swigCPtr, label, v, step, step_fast);
    return ret;
  }

  public bool InputInt(string label, int[] v, int step) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_1(swigCPtr, label, v, step);
    return ret;
  }

  public bool InputInt(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_2(swigCPtr, label, v);
    return ret;
  }

  public bool SliderInt(string label, int[] v, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_SliderInt(swigCPtr, label, v, v_min, v_max);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat2(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat3(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat4(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format, string display_format_max, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_0(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max, power);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format, string display_format_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_1(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_2(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_3(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_4(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_5(swigCPtr, label, v_current_min, v_current_max, v_speed);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_6(swigCPtr, label, v_current_min, v_current_max);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt2(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt3(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt4(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max, string display_format, string display_format_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_0(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_1(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_2(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_3(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_4(swigCPtr, label, v_current_min, v_current_max, v_speed);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_5(swigCPtr, label, v_current_min, v_current_max);
    return ret;
  }

  public bool ColorEdit4(string label, float[] col, ColorEditFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_ColorEdit4__SWIG_0(swigCPtr, label, col, (int)flags);
    return ret;
  }

  public bool ColorEdit4(string label, float[] col) {
    bool ret = EffekseerNativePINVOKE.GUIManager_ColorEdit4__SWIG_1(swigCPtr, label, col);
    return ret;
  }

  public bool TreeNode(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_TreeNode(swigCPtr, label);
    return ret;
  }

  public void TreePop() {
    EffekseerNativePINVOKE.GUIManager_TreePop(swigCPtr);
  }

  public bool BeginMainMenuBar() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMainMenuBar(swigCPtr);
    return ret;
  }

  public void EndMainMenuBar() {
    EffekseerNativePINVOKE.GUIManager_EndMainMenuBar(swigCPtr);
  }

  public bool BeginMenuBar() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenuBar(swigCPtr);
    return ret;
  }

  public void EndMenuBar() {
    EffekseerNativePINVOKE.GUIManager_EndMenuBar(swigCPtr);
  }

  public bool BeginMenu(string label, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenu__SWIG_0(swigCPtr, label, enabled);
    return ret;
  }

  public bool BeginMenu(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenu__SWIG_1(swigCPtr, label);
    return ret;
  }

  public void EndMenu() {
    EffekseerNativePINVOKE.GUIManager_EndMenu(swigCPtr);
  }

  public bool MenuItem(string label, string shortcut, bool selected, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_0(swigCPtr, label, shortcut, selected, enabled);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, bool selected) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_1(swigCPtr, label, shortcut, selected);
    return ret;
  }

  public bool MenuItem(string label, string shortcut) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_2(swigCPtr, label, shortcut);
    return ret;
  }

  public bool MenuItem(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_3(swigCPtr, label);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, bool[] p_selected, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_4(swigCPtr, label, shortcut, p_selected, enabled);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, bool[] p_selected) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_5(swigCPtr, label, shortcut, p_selected);
    return ret;
  }

  public void OpenPopup(string str_id) {
    EffekseerNativePINVOKE.GUIManager_OpenPopup(swigCPtr, str_id);
  }

  public bool BeginPopupModal(string name, bool[] p_open, WindowFlags extra_flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_0(swigCPtr, name, p_open, (int)extra_flags);
    return ret;
  }

  public bool BeginPopupModal(string name, bool[] p_open) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_1(swigCPtr, name, p_open);
    return ret;
  }

  public bool BeginPopupModal(string name) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_2(swigCPtr, name);
    return ret;
  }

  public bool BeginPopupContextItem(string str_id, int mouse_button) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_0(swigCPtr, str_id, mouse_button);
    return ret;
  }

  public bool BeginPopupContextItem(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_1(swigCPtr, str_id);
    return ret;
  }

  public bool BeginPopupContextItem() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_2(swigCPtr);
    return ret;
  }

  public void EndPopup() {
    EffekseerNativePINVOKE.GUIManager_EndPopup(swigCPtr);
  }

  public bool IsPopupOpen(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsPopupOpen(swigCPtr, str_id);
    return ret;
  }

  public void CloseCurrentPopup() {
    EffekseerNativePINVOKE.GUIManager_CloseCurrentPopup(swigCPtr);
  }

}

}
