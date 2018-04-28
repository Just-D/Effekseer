/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_EffekseerNative_WRAP_H_
#define SWIG_EffekseerNative_WRAP_H_

class SwigDirector_GUIManagerCallback : public efk::GUIManagerCallback, public Swig::Director {

public:
    SwigDirector_GUIManagerCallback();
    virtual ~SwigDirector_GUIManagerCallback();
    virtual void Resized(int x, int y);
    virtual void Droped();
    virtual void Focused();
    virtual bool Closing();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackResized, SWIG_Callback1_t callbackDroped, SWIG_Callback2_t callbackFocused, SWIG_Callback3_t callbackClosing);

private:
    SWIG_Callback0_t swig_callbackResized;
    SWIG_Callback1_t swig_callbackDroped;
    SWIG_Callback2_t swig_callbackFocused;
    SWIG_Callback3_t swig_callbackClosing;
    void swig_init_callbacks();
};


#endif