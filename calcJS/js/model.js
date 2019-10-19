let isCheck = true;
let isResult = true;
let countNumber = 0;
let memoryNumber = 0;
let operationType = '';

let dotBtn;
let plusBtn;
let display;
let clearBtn;
let minusBtn;
let resultBtn;
let divideBtn;
let buttonsList;
let multiplyBtn;

const model = {
    setIsCheck: function (value) {
        isCheck = value;
    },
    getIsCheck(value){
        return isCheck;
    },
    setIsResult(value){
        isResult = value;
    },
    getIsResult(value){
        return isResult;
    },
    setCountNumber(value){
        countNumber = value;
    },
    getCountNumber(){
        return +countNumber;
    },
    setMemoryNumber(value){
        memoryNumber = value;
    },
    getMemoryNumber(){
        return memoryNumber;
    },
    setOperationType(value){
        operationType = value;
    },
    getOperationType(){
        return operationType;
    },
};