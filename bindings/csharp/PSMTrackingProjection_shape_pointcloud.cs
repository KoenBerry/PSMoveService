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

public class PSMTrackingProjection_shape_pointcloud : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMTrackingProjection_shape_pointcloud(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMTrackingProjection_shape_pointcloud obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMTrackingProjection_shape_pointcloud() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMTrackingProjection_shape_pointcloud(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PSMVector2f[] points {
    get {
      PSMVector2f[] returnArray;
      
      int structSize = (int)PSMoveClientPINVOKE.PSMVector2f_getSize();
      System.IntPtr cPtr = PSMoveClientPINVOKE.PSMTrackingProjection_shape_pointcloud_points_get(swigCPtr);
      int len = this.point_count;
      if (len<=0)
      {
        return null;
      }
      returnArray = new PSMVector2f[len];
      for (int i = 0; i < len; ++i)
      {
          System.IntPtr data = new System.IntPtr(cPtr.ToInt64() + structSize * i);
          returnArray[i] = new PSMVector2f(data, false);        
      }

      return returnArray;
    }
  
  }

  public int point_count {
    get {
      int ret = PSMoveClientPINVOKE.PSMTrackingProjection_shape_pointcloud_point_count_get(swigCPtr);
      return ret;
    } 
  }

  public PSMTrackingProjection_shape_pointcloud() : this(PSMoveClientPINVOKE.new_PSMTrackingProjection_shape_pointcloud(), true) {
  }

}

}
