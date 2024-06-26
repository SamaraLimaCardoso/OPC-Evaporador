
export enum ObjectIds {
   PlantaEvaporador1 = 'i=250',
   PlantaEvaporador1_Tanque1 = 'i=251',
   PlantaEvaporador1_Tanque1_TT003 = 'i=252',
   PlantaEvaporador1_Tanque2 = 'i=260',
   PlantaEvaporador1_Tanque2_TT001 = 'i=261',
   PlantaEvaporador1_Tanque2_TV001 = 'i=269',
   PlantaEvaporador1_Tanque3 = 'i=282',
   PlantaEvaporador1_Tanque3_PT001 = 'i=283',
   PlantaEvaporador1_Tanque3_LT001 = 'i=291',
   PlantaEvaporador1_T1paraT2 = 'i=299',
   PlantaEvaporador1_T1paraT2_SC001 = 'i=300',
   PlantaEvaporador1_T1paraT3 = 'i=307',
   PlantaEvaporador1_T1paraT3_SC003 = 'i=308',
   PlantaEvaporador1_T2paraCx = 'i=315',
   PlantaEvaporador1_T2paraCx_FV002 = 'i=316',
   PlantaEvaporador1_T3paraCx = 'i=329',
   PlantaEvaporador1_T3paraCx_FV001 = 'i=330',
   PlantaEvaporador1_T3paraCx_SC002 = 'i=343',
   PlantaEvaporador1_T3paraCx_TT002 = 'i=350'
}

export enum ObjectTypeIds {
   GenericoSensorType = 'i=1',
   GenericoAtuadorType = 'i=9',
   GenericoInvFreqType = 'i=22',
   IndicadorNivelType = 'i=29',
   IndicadorTempType = 'i=30',
   MedidorPressaoType = 'i=31',
   ValvulaType = 'i=32',
   ResistenciaType = 'i=33',
   InvMotorType = 'i=34',
   Tanque1Type = 'i=35',
   Tanque2Type = 'i=44',
   Tanque3Type = 'i=66',
   T1paraT2Type = 'i=83',
   T1paraT3Type = 'i=91',
   T2paraCxType = 'i=99',
   T3paraCxType = 'i=113',
   EvaporadorPlantaType = 'i=142'
}

export enum VariableIds {
   PlantaEvaporador1_Tanque1_TT003_Output = 'i=253',
   PlantaEvaporador1_Tanque1_TT003_Output_EURange = 'i=257',
   PlantaEvaporador1_Tanque1_TT003_Unidade = 'i=259',
   PlantaEvaporador1_Tanque2_TT001_Output = 'i=262',
   PlantaEvaporador1_Tanque2_TT001_Output_EURange = 'i=266',
   PlantaEvaporador1_Tanque2_TT001_Unidade = 'i=268',
   PlantaEvaporador1_Tanque2_TV001_Input = 'i=270',
   PlantaEvaporador1_Tanque2_TV001_Input_EURange = 'i=274',
   PlantaEvaporador1_Tanque2_TV001_Output = 'i=276',
   PlantaEvaporador1_Tanque2_TV001_Output_EURange = 'i=280',
   PlantaEvaporador1_Tanque3_PT001_Output = 'i=284',
   PlantaEvaporador1_Tanque3_PT001_Output_EURange = 'i=288',
   PlantaEvaporador1_Tanque3_PT001_Unidade = 'i=290',
   PlantaEvaporador1_Tanque3_LT001_Output = 'i=292',
   PlantaEvaporador1_Tanque3_LT001_Output_EURange = 'i=296',
   PlantaEvaporador1_Tanque3_LT001_Unidade = 'i=298',
   PlantaEvaporador1_T1paraT2_SC001_pwm = 'i=301',
   PlantaEvaporador1_T1paraT2_SC001_pwm_EURange = 'i=305',
   PlantaEvaporador1_T1paraT3_SC003_pwm = 'i=309',
   PlantaEvaporador1_T1paraT3_SC003_pwm_EURange = 'i=313',
   PlantaEvaporador1_T2paraCx_FV002_Input = 'i=317',
   PlantaEvaporador1_T2paraCx_FV002_Input_EURange = 'i=321',
   PlantaEvaporador1_T2paraCx_FV002_Output = 'i=323',
   PlantaEvaporador1_T2paraCx_FV002_Output_EURange = 'i=327',
   PlantaEvaporador1_T3paraCx_FV001_Input = 'i=331',
   PlantaEvaporador1_T3paraCx_FV001_Input_EURange = 'i=335',
   PlantaEvaporador1_T3paraCx_FV001_Output = 'i=337',
   PlantaEvaporador1_T3paraCx_FV001_Output_EURange = 'i=341',
   PlantaEvaporador1_T3paraCx_SC002_pwm = 'i=344',
   PlantaEvaporador1_T3paraCx_SC002_pwm_EURange = 'i=348',
   PlantaEvaporador1_T3paraCx_TT002_Output = 'i=351',
   PlantaEvaporador1_T3paraCx_TT002_Output_EURange = 'i=355',
   PlantaEvaporador1_T3paraCx_TT002_Unidade = 'i=357'
}

export class StatusCode {
   public static isGood(code?: number): boolean {
      return !code || (code & 0xD0000000) === 0;
   }
   public static isUncertain(code?: number): boolean {
      return (code ?? 0 & 0x40000000) !== 0;
   }
   public static isBad(code?: number): boolean {
      return (code ?? 0 & 0x80000000) !== 0;
   }
}