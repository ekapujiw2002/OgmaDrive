//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class CornerEncoder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CornerEncoder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CornerEncoder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CornerEncoder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_CornerEncoder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void create(int inputWidth, int inputHeight, int chunkSize, int k) {
    eogmaneoPINVOKE.CornerEncoder_create(swigCPtr, inputWidth, inputHeight, chunkSize, k);
  }

  public void clearHiddenStates() {
    eogmaneoPINVOKE.CornerEncoder_clearHiddenStates(swigCPtr);
  }

  public void activate(StdVecf input, ComputeSystem system, float radius, float thresh, int samples) {
    eogmaneoPINVOKE.CornerEncoder_activate(swigCPtr, StdVecf.getCPtr(input), ComputeSystem.getCPtr(system), radius, thresh, samples);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getInputWidth() {
    int ret = eogmaneoPINVOKE.CornerEncoder_getInputWidth(swigCPtr);
    return ret;
  }

  public int getInputHeight() {
    int ret = eogmaneoPINVOKE.CornerEncoder_getInputHeight(swigCPtr);
    return ret;
  }

  public int getChunkSize() {
    int ret = eogmaneoPINVOKE.CornerEncoder_getChunkSize(swigCPtr);
    return ret;
  }

  public float getRadius() {
    float ret = eogmaneoPINVOKE.CornerEncoder_getRadius(swigCPtr);
    return ret;
  }

  public int getK() {
    int ret = eogmaneoPINVOKE.CornerEncoder_getK(swigCPtr);
    return ret;
  }

  public StdVeci getHiddenStates(int order) {
    StdVeci ret = new StdVeci(eogmaneoPINVOKE.CornerEncoder_getHiddenStates(swigCPtr, order), false);
    return ret;
  }

  public CornerEncoder() : this(eogmaneoPINVOKE.new_CornerEncoder(), true) {
  }

}

}
