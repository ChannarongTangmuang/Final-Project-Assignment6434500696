##SneakerShop By Channarong
### ความเป็นมาของโปรแกรม
1.สนใจเรื่องรองเท้าConvere<br/>
2.อยากมีร้านขายรองเท้าConverseเป็นของตนเอง<br/>
3.อยากศึกษาและมีโปรแกรมร้านขายรองConverseเท้าเป็นของตนเอง<br/>

<br/><br/>
### วัตถุประสงค์ของโปรแกรม
1.สำหรับผู้ที่สนใจจะเลือกซื้อรองเท้าConverse <br/>
2.เพื่อศึกษาค้นคว้าข้อมูลเกี่ยวกับรองเท้าConverse <br/>
3.เพื่อทำให้โปรแกรมการขายรองเท้าConverseมีหลากหลายมากขึ้น<br/>





<br/><br/>
### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- SneakerShop
    SneakerShop <|-- AllStar
    SneakerShop <|-- ChuckTaylor
    SneakerShop <|-- JackPurcell
    SneakerShop <|-- OneStar
    Program : +Main()
    class SneakerShop{
        +openToolStripMenuItem_Click()
        +saveToolStripMenuItem_Click()
        +buttonConfrim_Click()
        +buttonBuy_Click()
        +buttonClear_Click()
        +buttonCheck_Click()
    }
    class AllStar{
        +AllStarWhite()
        +AllStarRed()
        +AllStarBlack()
        +AllStarGray()
        +AllStarBlue()
    }
    class ChuckTaylor{
        +ChuckTaylorPink()
        +ChuckTaylorGreen()
        +ChuckTaylorWhite()
        +ChuckTaylorRed()
        +ChuckTaylorBlack()
    }
    class JackPurcell{
        +JackPurcellNavyBlue()
        +JackPurcellWhite()
    }
    class OneStar{
        +OneStarMustard()
        +OneStarBlack()
        +OneStarOliveGreen()
    }
```
<br/><br/>
### ผู้พัฒนาโปรแกรม
นายชาญณรงค์ แต่งเมือง 643450069-6
