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

public class PSMClientHMDInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMClientHMDInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMClientHMDInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMClientHMDInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMClientHMDInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int hmd_id {
    get {
      int ret = PSMoveClientPINVOKE.PSMClientHMDInfo_hmd_id_get(swigCPtr);
      return ret;
    } 
  }

  public PSMHmdType hmd_type {
    get {
      PSMHmdType ret = (PSMHmdType)PSMoveClientPINVOKE.PSMClientHMDInfo_hmd_type_get(swigCPtr);
      return ret;
    } 
  }

  public PSMTrackingColorType tracking_color_type {
    get {
      PSMTrackingColorType ret = (PSMTrackingColorType)PSMoveClientPINVOKE.PSMClientHMDInfo_tracking_color_type_get(swigCPtr);
      return ret;
    } 
  }

  public string device_path {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientHMDInfo_device_path_get(swigCPtr);
      return ret;
    } 
  }

  public string orientation_filter {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientHMDInfo_orientation_filter_get(swigCPtr);
      return ret;
    } 
  }

  public string position_filter {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientHMDInfo_position_filter_get(swigCPtr);
      return ret;
    } 
  }

  public float prediction_time {
    get {
      float ret = PSMoveClientPINVOKE.PSMClientHMDInfo_prediction_time_get(swigCPtr);
      return ret;
    } 
  }

  public PSMClientHMDInfo() : this(PSMoveClientPINVOKE.new_PSMClientHMDInfo(), true) {
  }

}

}
