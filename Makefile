BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

all: AFNetworking.dll

vendor:
	git submodule update --init --recursive

libAFNetworking.a: vendor
	xcodebuild -project "./AFNetworking Static Library.xcodeproj" -sdk iphonesimulator -configuration Release clean build
	xcodebuild -project "./AFNetworking Static Library.xcodeproj" -sdk iphoneos -configuration Release clean build
	lipo -create -output ./build/libAFNetworking.a ./build/Release-iphoneos/libAFNetworking.a ./build/Release-iphonesimulator/libAFNetworking.a
	cp ./build/libAFNetworking.a ./AFNetworking/libAFNetworking.a	
	rm -r build
	
AFNetworking.dll: libAFNetworking.a
	$(BTOUCH) AFNetworking/ApiDefinition.cs AFNetworking/libAFNetworking.linkwith.cs -s:AFNetworking/StructsAndEnums.cs --out=$@ --link-with=AFNetworking/libAFNetworking.a,libAFNetworking.a

clean:
	rm -r vendor
	rm -r ./AFNetworking/bin
	rm -r ./AFNetworking/obj
	rm ./AFNetworking/libAFNetworking.a
	rm ./AFNetworking.dll
