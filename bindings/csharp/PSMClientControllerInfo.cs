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

public class PSMClientControllerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMClientControllerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMClientControllerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMClientControllerInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMClientControllerInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int controller_id {
    get {
      int ret = PSMoveClientPINVOKE.PSMClientControllerInfo_controller_id_get(swigCPtr);
      return ret;
    } 
  }

  public PSMControllerType controller_type {
    get {
      PSMControllerType ret = (PSMControllerType)PSMoveClientPINVOKE.PSMClientControllerInfo_controller_type_get(swigCPtr);
      return ret;
    } 
  }

  public PSMControllerHand controller_hand {
    get {
      PSMControllerHand ret = (PSMControllerHand)PSMoveClientPINVOKE.PSMClientControllerInfo_controller_hand_get(swigCPtr);
      return ret;
    } 
  }

  public PSMTrackingColorType tracking_color_type {
    get {
      PSMTrackingColorType ret = (PSMTrackingColorType)PSMoveClientPINVOKE.PSMClientControllerInfo_tracking_color_type_get(swigCPtr);
      return ret;
    } 
  }

  public bool is_bluetooth {
    get {
      bool ret = PSMoveClientPINVOKE.PSMClientControllerInfo_is_bluetooth_get(swigCPtr);
      return ret;
    } 
  }

  public bool has_magnetometer {
    get {
      bool ret = PSMoveClientPINVOKE.PSMClientControllerInfo_has_magnetometer_get(swigCPtr);
      return ret;
    } 
  }

  public float prediction_time {
    get {
      float ret = PSMoveClientPINVOKE.PSMClientControllerInfo_prediction_time_get(swigCPtr);
      return ret;
    } 
  }

  public int gamepad_index {
    get {
      int ret = PSMoveClientPINVOKE.PSMClientControllerInfo_gamepad_index_get(swigCPtr);
      return ret;
    } 
  }

  public string device_path {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_device_path_get(swigCPtr);
      return ret;
    } 
  }

  public string orientation_filter {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_orientation_filter_get(swigCPtr);
      return ret;
    } 
  }

  public string position_filter {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_position_filter_get(swigCPtr);
      return ret;
    } 
  }

  public string gyro_gain_setting {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_gyro_gain_setting_get(swigCPtr);
      return ret;
    } 
  }

  public string controller_serial {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_controller_serial_get(swigCPtr);
      return ret;
    } 
  }

  public string assigned_host_serial {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_assigned_host_serial_get(swigCPtr);
      return ret;
    } 
  }

  public string parent_controller_serial {
    get {
      string ret = PSMoveClientPINVOKE.PSMClientControllerInfo_parent_controller_serial_get(swigCPtr);
      return ret;
    } 
  }

  public PSMClientControllerInfo() : this(PSMoveClientPINVOKE.new_PSMClientControllerInfo(), true) {
  }

}

}
