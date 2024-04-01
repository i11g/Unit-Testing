import {LookupChar} from "./CharLookup.js"; 
import {expect} from "chai"; 

describe ('LookupChar', () => {
    it('should retrun undefined if not a string is given',()=> {
        //Arrange
        const notString=1234
        //Act
        const result=LookupChar(notString, 5); 
        //Assert
        expect(result).to.be.equal(undefined);
    })
    it('should retrun undefined if not a number is given',()=> {
        //Arrange
        const string="string"
        const index="text"
        //Act
        const result=LookupChar(string, index); 
        //Assert
        expect(result).to.be.equal(undefined);
    })
    it('should retrun undefined if not a number is given',()=> {
        //Arrange
        const string="string"
        const index=6;
        const index1=-6
        //Act
        const result=LookupChar(string, index);
        const result1=LookupChar(string,index1) 
        //Assert
        expect(result).to.be.equal("Incorrect index");
        expect(result1).to.be.equal("Incorrect index")
    })
    it('should retrun undefined if not a number is given',()=> {
        //Arrange
        const string="string"
        const index=4;
        const index1=3
        //Act
        const result=LookupChar(string, index);
        const result1=LookupChar(string,index1) 
        //Assert
        expect(result).to.be.equal("n");
        expect(result1).to.be.equal("i")
    })
})
