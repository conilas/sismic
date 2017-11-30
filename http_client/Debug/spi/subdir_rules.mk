################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL = cmd.exe

# Each subdirectory must supply rules for building sources it contributes
spi/spi.obj: C:/ti/CC3100SDK_1.1.0/cc3100-sdk/platform/msp430f5529lp/spi.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: $<'
	@echo 'Invoking: MSP430 Compiler'
	"C:/ti/ccsv7/tools/compiler/msp430_4.3.8/bin/cl430" -vmspx --abi=coffabi --include_path="C:/ti/ccsv7/ccs_base/msp430/include" --include_path="C:/ti/CC3100SDK_1.1.0/cc3100-sdk/netapps" --include_path="C:/ti/CC3100SDK_1.1.0/cc3100-sdk/examples/common" --include_path="C:/ti/CC3100SDK_1.1.0/cc3100-sdk/simplelink/include" --include_path="C:/ti/CC3100SDK_1.1.0/cc3100-sdk/simplelink/source" --include_path="C:/ti/CC3100SDK_1.1.0/cc3100-sdk/platform/msp430f5529lp" --include_path="C:/ti/ccsv7/tools/compiler/msp430_4.3.8/include" -g --define=__MSP430F5529__ --define=__SL__ --define=__CCS__ --define=_USE_CLI_ --diag_warning=225 --display_error_number --diag_wrap=off --silicon_errata=CPU21 --silicon_errata=CPU22 --silicon_errata=CPU23 --silicon_errata=CPU40 --printf_support=full --preproc_with_compile --preproc_dependency="spi/spi.d" --obj_directory="spi" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: $<'
	@echo ' '


