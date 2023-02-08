<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=waving&height=250&color=auto&text=Shader%20Study&fontColor=auto)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=UNITY&fontColor=000000&fontSize=20)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=2022.1.20~&fontColor=000000&fontSize=15)
  
<div align="left">

```
  📌  최종 목표 : 쉐이더 그래프를 사용하여 실감 넘치는 물결치는 파도를 구현
  ☑️  유형 : 개인 프로젝트
  ☑️  사용 기술 : C#, 유니티 URP 렌더 파이프라인
  💡  기대 : 쉐이더의 대략적인 사용법 이해, 부력을 코드로 표현해보기
  💔  예상 장애 요소 : 쉐이더 그래프 사용법 지식의 부족, 참고자료의 설명 부족
 
  Objective : Create immersive realistic wave using URP shader graph with unity
  Private Project, using C# and Unity URP Rendere Pipeline
  Might be able to understand brief techniques of how to use shader graph and express buyoancy with C# script/
  Might bump in to obstacles due to lack of understanding of shadergraph or struggle from lack of explanation in tutorials.
```
  
<div align="center">
<br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20SCHEDULE&fontColor=000000&fontSize=15)

  
 
|날짜|차시|로그|참고자료(Credits)|코드|
|---|---------|---------|----|-----|
|2023-01-21|1-1|waterPhysics| [shaderManipulation1](https://catlikecoding.com/unity/tutorials/flow/waves/) <br> [meshManipulation](https://www.youtube.com/watch?v=_Ij24zRI9J0) <br> [buoyancy](https://www.youtube.com/watch?v=iasDPyC0QOg&t=496s)|[WaterShaderGraph](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/UnbendedWater%201.shadergraph) <br> [OceanManager C#](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/OceanManager.cs)|
|2022-01-28|1 - 2|FoamShader and Texture Redone|[FoamShader1](https://www.youtube.com/watch?v=MHdDUqJHJxM&t=464s) <br> [FoamShader2](https://www.youtube.com/watch?v=MHdDUqJHJxM&t=464s)||
|2022-01-29|1 - 3|PlayerController||[OceanFollow(C#)](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/OceanPlayerFollow.cs) <br> [PlayerMove](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/PlayerMove.cs)|
|2023-01-30|1 - 4|DepthMask&&BoatController|[DepthMask](https://web.archive.org/web/20210831213650/http://wiki.unity3d.com:80/index.php/DepthMask)||
|2023-01-31|2|Orthographic Camera|[Orthographic Depth Calc](https://twitter.com/cyanilux/status/1169932943869059073?lang=en)||
|2023-02-01|3|Bending Shader|[Curved World Shader Shader Graph](https://www.youtube.com/watch?v=UoK7VRs3tfo) <br> [World Bending](https://www.youtube.com/watch?v=SOK3Ias5Nk0&t=87s)|[BendedWaterShaderGraph](https://github.com/swimmin99/PrivateProject-ShaderStudy/blob/main/BendedWater.shadergraph)|
 
  
  <br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20LOG&fontColor=000000&fontSize=15)

  
---
</div>
<div align="left">

<u><strong>쉐이더 스터디1 (Shader Study 1)</strong></u>
  

```
📌목표 : 쉐이더 그래프를 사용하여 물결치는 파도를 구현.
세부목표1 : 메쉬를 변경시키지 않고 쉐이더로 파고를 구현할 것.
세부목표2 : 부력을 사용할 수 있도록 vertex 높이 변화를 전달 할 수 있도록 할 것.
세부목표3 : 물 위에 뜬 물체의 경우 Foam(거품)이 생기는 효과를 쉐이더로 구현할 것.
```

  
<div align="center">
  <img src ="https://user-images.githubusercontent.com/109887066/216982077-fa823f73-ac51-4242-a5da-9ad5355b239b.png" width="70%" height="70%"/>
  
```시도1 : 물결의 그래픽 적인 부분만 구현한 모습```
  
  <img src ="https://user-images.githubusercontent.com/109887066/216984447-1218c658-899c-43d6-a8f1-da94ce68766d.gif" width="30%" height="30%"/>

  ```시도2 : 간단한 물체 부력 테스트```
  
   <img src ="https://user-images.githubusercontent.com/109887066/216985735-af88be11-deac-480f-b3f4-d9ce75399afd.gif" width="30%" height="30%"/>

  ```시도3 : 물체의 물에 잠긴 부분에 Foam 효과를 추가한 모습```<br> 
    <img src ="https://user-images.githubusercontent.com/109887066/216986154-96ab24ec-b816-4c5e-b422-b5679df2e338.gif" width="35%" height="35%"/>

  ```시도4 : 물 위에서 이동하는 물체```
  
  <img src ="https://user-images.githubusercontent.com/109887066/216976847-f30eba03-0895-40c4-95e7-8a940ff507a2.png"  width="70%" height="70%"/>

  ```완성된 쉐이더 그래프```

<div align="left">


```
💡발전한 점
1.유니티의 쉐이더 그래프의 대략적인 사용법과 스크립트로 연동하는 법을 배움.
2.굳이 스크립트를 작성하지 않아도 노드를 통해 쉽게 구현이 가능하다는 것을 깨달음.

📝앞으로의 방향
1.쉐이더 그래프를 자유자재로 사용할 수 있도록 다양한 쉐이더를 구현해본다.
2.참고 자료에 의지하는 정도를 줄여 나만의 개성 있는 쉐이더를 만들어본다.
```
  

---
</div>
<div align="left">

<u><strong>쉐이더 스터디2 (Shader Study 2)</strong></u>

```
📌목표 : Orthographic 카메라 뷰에서 사용가능한 물 쉐이더를 만든다.
세부목표 : ScreenDepth를 Perspective View 카메라와 동일하게 사용할 수 없기에 새로운 방법을 찾는다.
```
   <div align="center"> 
   <img src ="https://user-images.githubusercontent.com/109887066/216987145-ad6f8b6f-9550-489a-8632-56ac7d76f387.gif" width="40%" height="40%"/>  

  ```Orthographic Camera View로 구현한 물 쉐이더```


  <img src ="https://user-images.githubusercontent.com/109887066/216978543-a39f7c5b-b95e-4b9c-b4de-ea2ee5afd1db.png"  width="75%" height="75%"/>
     
 ```완성된 쉐이더 그래프의 모습```

 <div align="left">
   
  ```
💡발전한 점
1.View에 따라 다르게 계산되는 Depth를 이용하는 방법을 알게 됨.
2.Perspective와 달리 Orthographic View는 독특한 만큼 여러가지 애로사항이 많다는 것을 알게 됨.
  
📝앞으로의 방향
1.아직 쉐이더에 대한 이해가 부족한 것으로 느껴짐. 세부 노드들의 기능과 쓰임새에 대해 더욱 깊게 학습해야 함.
2.Orthographic 카메라 뷰를 사용할 때는 사전에 그래픽 요소를 어떻게 구현할지 세부적으로 계획해야겠다고 생각 함.
 ```
  
---
---
 </div>
<div align="left">
<u><strong>쉐이더 스터디3 (Shader Study 3)</strong></u>

```
📌목표 : World Bending 효과를 주어 지평선으로 다가갈수록 아래로 휘는 효과를 준다.
세부목표1 : 일반 오브젝트에 적용 가능한 쉐이더를 만든다.
세부목표2 : 해당 그래프를 서브 그래프화 시킨다.
세부목표3 : 해당 그래프를 이전에 구현한 물 쉐이더와 합체 시킨다.
```
   <div align="center"> 
   <img src ="https://user-images.githubusercontent.com/109887066/216990234-f97ea8c3-3393-466a-8230-92a43c8b6b5e.gif" width="40%" height="40%"/>  

  ```World Bending 효과를 추가한 물 쉐이더```


  <img src ="https://user-images.githubusercontent.com/109887066/216978837-42eaeabc-e0a7-4ec7-ba0a-6e453aeee2c9.png"  width="75%" height="75%"/>
     
  ```참고한 식 출처 : [Youtube](https://www.youtube.com/watch?v=UoK7VRs3tfo)```

  <img src ="https://user-images.githubusercontent.com/109887066/216978984-044a594c-4673-4d5f-ba70-865357b4ff41.png"  width="75%" height="75%"/>

  ```최종 쉐이더 그래프```

     
<div align="left">
  
```
💡발전한 점
1.이전 보다 쉐이더 그래프의 세부 노드에 대한 이해도가 증가함.
2.Import한 3D 모델이 FBX 형식일 경우에 material과 texture을 따로 Extract 하여 쉐이더를 적용해야 한다는 사실을 배움.
📝앞으로의 방향
1.Shader Graph를 사용하는 다른 Shader와 새로운 Shader를 합치는 방식은 이해하였으나 
  합치려는 쉐이더의 종류가 다른 경우 (URP Lit Shader/Legacy Surface Shader/HDRP Shader)일 경우에는 어려움. 
  이에 대한 자료를 더 찾아볼 것.
```
  
---

    
```
💡느낀점 : 유니티가 제공하는 URP 쉐이더 그래프는 실로 강력한 툴이다. 
  그러나 라이팅과 물리 법칙들을 쉐이더로 구현하기 위해서는 수학에 대한 지식을 더 쌓아야 할 것으로 보인다. 
  또한 부력을 표현하기 위해 사용하였던 스크립트를 완벽하게 소화해 낸 것 같지 않다. 
  따라서 해당 부분을 복습하고 나의 입맛대로 고치면서 친해질 필요가 있다. 
  배에 물이 차는 것을 방지하는 Depth Mask의 경우 일반 View는 적용시켰지만 World Bending 물 쉐이더에 적용시키지 못하였다. 
  해당 문제를 해결하기 위해서는 쉐이더 그래프를 사용하지 않고 스크립트를 통해 쉐이더를 적용시키는 법 또한 배워야 할 것으로 보인다.
  
  또한 아직 몇가지 문제가 해결되지 않았기에 추후 프로젝트에 시간을 더 투입해 완성해 나가야 할 것으로 보인다.
  
  Overall : URP Shader Graph is a powerful tool for creating a realistic 3d effects.
  However lighting and Physics part demands deeper understanding in math.
  Thus, haven't fully comprehended buyoancy script (FloatingObjects C#) yet.
  Haven't figure out how to combine bended water shader with depth mask shader since its based on totally different shader.
  
  다음 스텝 : 3D 그래픽과 관련된 수학 서적 읽기, 스크립트 손보기
  Next step would be peeping through math lecture and books in library and review my scripts and work more on shader.
```
  

