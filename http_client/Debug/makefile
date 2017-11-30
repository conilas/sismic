################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL = cmd.exe

CG_TOOL_ROOT := C:/ti/ccsv7/tools/compiler/msp430_4.3.8

GEN_OPTS__FLAG := 
GEN_CMDS__FLAG := 

ORDERED_OBJS += \
"./jsmn.obj" \
"./main.obj" \
"./board/board.obj" \
"./cli_uart/cli_uart.obj" \
"./simplelink/source/device.obj" \
"./simplelink/source/driver.obj" \
"./simplelink/source/flowcont.obj" \
"./simplelink/source/fs.obj" \
"./simplelink/source/netapp.obj" \
"./simplelink/source/netcfg.obj" \
"./simplelink/source/nonos.obj" \
"./simplelink/source/socket.obj" \
"./simplelink/source/spawn.obj" \
"./simplelink/source/wlan.obj" \
"./spi/spi.obj" \
"../lnk_msp430f5529.cmd" \
$(GEN_CMDS__FLAG) \
-llibc.a \
-lhttp_lib.lib \

-include ../makefile.init

RM := DEL /F
RMDIR := RMDIR /S/Q

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir_vars.mk
-include board/subdir_vars.mk
-include cli_uart/subdir_vars.mk
-include simplelink/source/subdir_vars.mk
-include spi/subdir_vars.mk
-include subdir_rules.mk
-include board/subdir_rules.mk
-include cli_uart/subdir_rules.mk
-include simplelink/source/subdir_rules.mk
-include spi/subdir_rules.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(C55_DEPS)),)
-include $(C55_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(S67_DEPS)),)
-include $(S67_DEPS)
endif
ifneq ($(strip $(S62_DEPS)),)
-include $(S62_DEPS)
endif
ifneq ($(strip $(S_DEPS)),)
-include $(S_DEPS)
endif
ifneq ($(strip $(OPT_DEPS)),)
-include $(OPT_DEPS)
endif
ifneq ($(strip $(C??_DEPS)),)
-include $(C??_DEPS)
endif
ifneq ($(strip $(ASM_UPPER_DEPS)),)
-include $(ASM_UPPER_DEPS)
endif
ifneq ($(strip $(S??_DEPS)),)
-include $(S??_DEPS)
endif
ifneq ($(strip $(C64_DEPS)),)
-include $(C64_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(S64_DEPS)),)
-include $(S64_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(CLA_DEPS)),)
-include $(CLA_DEPS)
endif
ifneq ($(strip $(S55_DEPS)),)
-include $(S55_DEPS)
endif
ifneq ($(strip $(SV7A_DEPS)),)
-include $(SV7A_DEPS)
endif
ifneq ($(strip $(C62_DEPS)),)
-include $(C62_DEPS)
endif
ifneq ($(strip $(C67_DEPS)),)
-include $(C67_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(K_DEPS)),)
-include $(K_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C43_DEPS)),)
-include $(C43_DEPS)
endif
ifneq ($(strip $(S43_DEPS)),)
-include $(S43_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(SA_DEPS)),)
-include $(SA_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
EXE_OUTPUTS += \
http_client.out \

EXE_OUTPUTS__QUOTED += \
"http_client.out" \

BIN_OUTPUTS += \
http_client.hex \

BIN_OUTPUTS__QUOTED += \
"http_client.hex" \


# All Target
all: http_client.out

# Tool invocations
http_client.out: $(OBJS) $(CMD_SRCS) $(GEN_CMDS)
	@echo 'Building target: $@'
	@echo 'Invoking: MSP430 Linker'
	"C:/ti/ccsv7/tools/compiler/msp430_4.3.8/bin/cl430" -vmspx --abi=coffabi -g --define=__MSP430F5529__ --define=__SL__ --define=__CCS__ --define=_USE_CLI_ --diag_warning=225 --display_error_number --diag_wrap=off --silicon_errata=CPU21 --silicon_errata=CPU22 --silicon_errata=CPU23 --silicon_errata=CPU40 --printf_support=full -z -m"http_client.map" --heap_size=500 --stack_size=500 --use_hw_mpy=F5 --cinit_hold_wdt=on -i"C:/ti/ccsv7/ccs_base/msp430/include" -i"C:/ti/CC3100SDK_1.1.0/cc3100-sdk/platform/msp430f5529lp/library_project_ccs/http_lib/Debug" -i"C:/ti/ccsv7/tools/compiler/msp430_4.3.8/lib" -i"C:/ti/ccsv7/tools/compiler/msp430_4.3.8/include" -i"C:/ti/ccsv7/ccs_base/msp430/lib/5xx_6xx_FRxx" --reread_libs --warn_sections --display_error_number --diag_wrap=off --xml_link_info="http_client_linkInfo.xml" --rom_model -o "http_client.out" $(ORDERED_OBJS)
	@echo 'Finished building target: $@'
	@echo ' '

http_client.hex: $(EXE_OUTPUTS)
	@echo 'Invoking: MSP430 Hex Utility'
	"C:/ti/ccsv7/tools/compiler/msp430_4.3.8/bin/hex430"  -o "http_client.hex" $(EXE_OUTPUTS__QUOTED)
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(BIN_OUTPUTS__QUOTED)$(EXE_OUTPUTS__QUOTED)
	-$(RM) "jsmn.obj" "main.obj" "board\board.obj" "cli_uart\cli_uart.obj" "simplelink\source\device.obj" "simplelink\source\driver.obj" "simplelink\source\flowcont.obj" "simplelink\source\fs.obj" "simplelink\source\netapp.obj" "simplelink\source\netcfg.obj" "simplelink\source\nonos.obj" "simplelink\source\socket.obj" "simplelink\source\spawn.obj" "simplelink\source\wlan.obj" "spi\spi.obj" 
	-$(RM) "jsmn.d" "main.d" "board\board.d" "cli_uart\cli_uart.d" "simplelink\source\device.d" "simplelink\source\driver.d" "simplelink\source\flowcont.d" "simplelink\source\fs.d" "simplelink\source\netapp.d" "simplelink\source\netcfg.d" "simplelink\source\nonos.d" "simplelink\source\socket.d" "simplelink\source\spawn.d" "simplelink\source\wlan.d" "spi\spi.d" 
	-@echo 'Finished clean'
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets

