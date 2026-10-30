# MyVR · VR 입력·상호작용 학습

Unity XR 환경의 이동 입력과 손 애니메이션을 시험하는 VR 학습 프로젝트입니다. 기존 FPS 관련 코드와 XR 템플릿·샘플이 함께 포함되어 있습니다.

## 학습·재구현 대상

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

## 학습 방식과 AI 활용

수업 예제를 직접 제작한 뒤 수업에서 사용한 에셋과 관련 자료를 바탕으로 AI를 활용해 같은 기능을 다시 구현하는 학습을 진행했습니다. 수업 실습과 AI를 활용한 재구현 작업이 함께 포함된 학습 과정입니다.

| 구분 | 내용 |
| --- | --- |
| 학습 기반 | 수업에서 다룬 게임 기능과 사용 에셋 |
| AI 활용 | 기존 학습 내용을 바탕으로 기능을 재구현하는 과정에 활용 |
| 자료 성격 | 게임 동작과 구현 구조를 익히기 위한 실습 기록 |

위 기능 목록은 저장소의 코드 구성을 설명합니다. 파일별 수업 예제와 AI 재구현의 구분은 개별 작업 기록을 기준으로 확인합니다.

## 검증과 리소스

실행·빌드 결과는 각 실습 당시의 기록을 기준으로 하며 이 문서의 수정으로 새로운 검증 결과가 추가된 것은 아닙니다. 수업 에셋과 외부 샘플·라이브러리는 각 제공자의 라이선스를 따릅니다.
