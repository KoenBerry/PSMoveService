//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PSMoveService {

public class PSMQuatf : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMQuatf(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMQuatf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMQuatf() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMQuatf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float w {
    get {
      float ret = PSMoveClientPINVOKE.PSMQuatf_w_get(swigCPtr);
      return ret;
    } 
  }

  public float x {
    get {
      float ret = PSMoveClientPINVOKE.PSMQuatf_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    get {
      float ret = PSMoveClientPINVOKE.PSMQuatf_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    get {
      float ret = PSMoveClientPINVOKE.PSMQuatf_z_get(swigCPtr);
      return ret;
    } 
  }

  public PSMQuatf() : this(PSMoveClientPINVOKE.new_PSMQuatf(), true) {
  }

}

}
