import { isSymmetric } from "./isSymmetric.js";
import{expect} from  "chai"; 

describe('isSymmetric', ()=>{
   
    it('should return true if given an empty array', () =>{
        //Arrange
        const emptyArray=[];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.true
    })
    it('should return false if a non-array is given',()=>{
        //Arrange
        const obj={
            name:"iv",
            age:20
        };
        //Act
        const result=isSymmetric(obj);
        //Assert
        expect(result).to.be.false
    })
    it ('should return false if non-symmetric array is given', ()=>{
        //Arrange
        const emptyArray=[1,2,3];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.false
    })
    it ('should return true if a symmetric array is given',()=>{
        //Arrange
        const symmetricArray=[1,2,3,2,1];
        //Act
        const result=isSymmetric(symmetricArray);
        //Assert
        expect(result).to.be.true
    })
    it ('should return true if a symmetric array with strings is given',()=>{
        //Arrange
        const symmetricArray=["1","2","3","2","1"];
        //Act
        const result=isSymmetric(symmetricArray);
        //Assert
        expect(result).to.be.true
    })
    it ('should return false if non-symmetric array with numbers and strings  is given', ()=>{
        //Arrange
        const emptyArray=[1,"2",3];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.false
    })
    it ('should return true if an array with one number is given', ()=>{
        //Arrange
        const emptyArray=[1];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.true
    })
    it ('should return true if non-symmetric array with numbers is given', ()=>{
        //Arrange
        const emptyArray=[1,1,1,1,1,1];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.true
    })
    it ('should return false with 0 given', ()=>{
        //Arrange
        const emptyArray=[0,1];
        //Act
        const result=isSymmetric(emptyArray);
        //Assert
        expect(result).to.be.false
    })
    it ('should return false if non-symmetric array is given', ()=>{
         //Arrange
         const emptyArray=[1,1,1,'1','1','1'];
         //Act
         const result=isSymmetric(emptyArray);
         //Assert
         expect(result).to.be.false
    })
    it('should return false if a non-array value if given', ()=> {
        //Arrange
        //Act
        const nanResult=isSymmetric(NaN);
        const undefinedResult=isSymmetric(undefined);
        const nullResult=isSymmetric(null);
        const stringResult=isSymmetric('string');
        const numberResult=isSymmetric(123)
        //Assert
        expect(nanResult).to.be.false;
        expect(undefinedResult).to.be.false;
        expect(nullResult).to.be.false;
        expect(stringResult).to.be.false;
        expect(numberResult).to.be.false;
    })

})
 