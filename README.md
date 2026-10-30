# MyVR · VR 입력·상호작용 학습

Unity XR 환경의 이동 입력과 손 애니메이션을 시험하는 VR 학습 프로젝트입니다. 기존 FPS 관련 코드와 XR 템플릿·샘플이 함께 포함되어 있습니다.

## 확인할 기능

- 입력값에 따른 왼손·오른손 텔레포트 레이 활성화
- 컨트롤러 입력을 이용한 손 애니메이션 처리
- VR 플레이 씬과 기존 FPS 기반 실습 자료

## 주요 코드와 구조

| 경로 | 역할 |
| --- | --- |
| [Assets/MyVR/Scripts/ActivateTeleportRay.cs](Assets/MyVR/Scripts/ActivateTeleportRay.cs) | 텔레포트 레이 활성화 입력 |
| [Assets/MyVR/Scripts/AnimateHandOnInput.cs](Assets/MyVR/Scripts/AnimateHandOnInput.cs) | 손 애니메이션 입력 |
| [Assets/MyVR/Scenes/VRPlayScene.unity](Assets/MyVR/Scenes/VRPlayScene.unity) | 빌드 설정에 등록된 VR 씬 |
| [Assets/MyFps](Assets/MyFps) | 기존 FPS 실습 코드 |
| [Assets/VRTemplateAssets](Assets/VRTemplateAssets) | 외부 VR 템플릿 자료 |

## 실행 방법

1. Unity Hub에서 저장소 폴더를 프로젝트로 추가합니다.
2. **Unity 6000.3.13f1**로 열고 패키지 복원과 임포트를 기다립니다.
3. [시작 씬](Assets/MyVR/Scenes/VRPlayScene.unity)을 엽니다.
4. Play Mode에서 동작을 확인합니다.

동일한 이름의 씬이 여러 경로에 있어 위 시작 씬 경로를 기준으로 확인합니다. VR 실기기 실행에는 프로젝트의 XR 설정과 연결 환경이 필요합니다.

## 작업 범위와 검증

수업 기반 학습 프로젝트입니다. 위 목록은 저장소의 코드 구성에 근거한 기능 설명이며 수업 예제와 개인 확장 기능의 구분은 별도 작업 기록을 기준으로 합니다. 이번 문서 정리는 새로 수행한 실행·빌드 시험의 결과를 의미하지 않습니다.

외부 에셋과 샘플은 자체 제작 코드와 구분하며 각 리소스의 라이선스를 따릅니다.
