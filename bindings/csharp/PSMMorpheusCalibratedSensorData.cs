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

public class PSMMorpheusCalibratedSensorData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMMorpheusCalibratedSensorData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMMorpheusCalibratedSensorData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMMorpheusCalibratedSensorData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMMorpheusCalibratedSensorData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PSMVector3f Accelerometer {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMMorpheusCalibratedSensorData_Accelerometer_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMVector3f Gyroscope {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMMorpheusCalibratedSensorData_Gyroscope_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public double TimeInSeconds {
    get {
      double ret = PSMoveClientPINVOKE.PSMMorpheusCalibratedSensorData_TimeInSeconds_get(swigCPtr);
      return ret;
    } 
  }

  public PSMMorpheusCalibratedSensorData() : this(PSMoveClientPINVOKE.new_PSMMorpheusCalibratedSensorData(), true) {
  }

}

}
