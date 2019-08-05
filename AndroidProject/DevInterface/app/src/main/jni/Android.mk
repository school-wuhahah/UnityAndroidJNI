LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)
LOCAL_MODULE    :=  CppInterface

LOCAL_SRC_FILES :=  \
    ../cpp/Debug.cpp    \
    ../cpp/DevFuncs.cpp \
    ../cpp/CppInterface.cpp \

LOCAL_C_INCLUDES := \
    $(LOCAL_PATH)../cpp \

include $(BUILD_SHARED_LIBRARY)