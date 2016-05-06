XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/STPopup.xcodeproj
TARGET=STPopup

all: libSTPopup.a

libSTPopup-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libSTPopup-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSTPopup-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSTPopup.a: libSTPopup-i386.a libSTPopup-armv7.a libSTPopup-arm64.a
	lipo -create -output $@ $^

clean: -rm -f *.a *.dll