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

public class PSMRawTrackerData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMRawTrackerData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMRawTrackerData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMRawTrackerData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMRawTrackerData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int TrackerID {
    get {
      int ret = PSMoveClientPINVOKE.PSMRawTrackerData_TrackerID_get(swigCPtr);
      return ret;
    } 
  }

  public PSMVector2f ScreenLocation {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_ScreenLocation_get(swigCPtr);
      PSMVector2f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector2f(cPtr, false);
      return ret;
    } 
  }

  public PSMVector3f RelativePositionCm {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_RelativePositionCm_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMQuatf RelativeOrientation {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_RelativeOrientation_get(swigCPtr);
      PSMQuatf ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMQuatf(cPtr, false);
      return ret;
    } 
  }

  public PSMTrackingProjection TrackingProjection {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_TrackingProjection_get(swigCPtr);
      PSMTrackingProjection ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMTrackingProjection(cPtr, false);
      return ret;
    } 
  }

  public uint ValidTrackerBitmask {
    get {
      uint ret = PSMoveClientPINVOKE.PSMRawTrackerData_ValidTrackerBitmask_get(swigCPtr);
      return ret;
    } 
  }

  public PSMVector3f MulticamPositionCm {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_MulticamPositionCm_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMQuatf MulticamOrientation {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMRawTrackerData_MulticamOrientation_get(swigCPtr);
      PSMQuatf ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMQuatf(cPtr, false);
      return ret;
    } 
  }

  public bool bMulticamPositionValid {
    get {
      bool ret = PSMoveClientPINVOKE.PSMRawTrackerData_bMulticamPositionValid_get(swigCPtr);
      return ret;
    } 
  }

  public bool bMulticamOrientationValid {
    get {
      bool ret = PSMoveClientPINVOKE.PSMRawTrackerData_bMulticamOrientationValid_get(swigCPtr);
      return ret;
    } 
  }

  public PSMRawTrackerData() : this(PSMoveClientPINVOKE.new_PSMRawTrackerData(), true) {
  }

}

}
