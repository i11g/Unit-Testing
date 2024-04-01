import {isOddOrEven} from "./isOddOrEven.js";
import {expect} from "chai"; 

describe ('isOddOrEven', () => {
    it('should retrun undefined if not string is given', ()=>{
        //Arrange
        const notString=12345;
        //Act
        const result=isOddOrEven(notString);
        //Assert
        expect(result).to.equal(undefined);
    })
    it('should return undefined is not string is given', ()=>{
        //Arrange
        const notStirng=[];
        //Act
        const result=isOddOrEven(notStirng);
        //Assert
        expect(result).to.equal(undefined); 
    })
    it('should return even if a string with a even length is given', () => {
        //Arrange
        const string="string";
        //Act
        const result=isOddOrEven(string);
        //Assert
        expect(result).to.equal("even");
    } )
    it('should return odd if a string with a odd length is gievn', () => {
        //Arrange
        const oddstring="Sofia";
        //Act
        const result=isOddOrEven(oddstring);
        //Assert
        expect(result).to.equal("odd");
    })
})