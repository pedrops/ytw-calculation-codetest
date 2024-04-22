export interface Bond {
    name: string;
    faceValue: number;
    couponRate: number;
    maturityDate: Date;
    couponType: string;
    bondType: string;
  }

  export interface Ytw {
    calculatedYtw: number;
  }