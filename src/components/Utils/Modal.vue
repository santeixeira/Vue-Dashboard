<template>
  <transition name="fade">
    <div class="vue-modal" v-show="open">
      <transition name="drop-in">
        <div class="vue-modal-inner" v-show="open">
          <div class="vue-modal-content">
            <div class="columns">
              <button type="button" class="close" @click="close">
                <i class="fas fa-close"></i>
              </button>
            </div>
            <slot></slot>
          </div>
        </div>
      </transition>
    </div>
  </transition>
</template>

<script lang="ts">
import { defineComponent, onMounted, onUnmounted } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Modal",
  props: {
    open: {
      type: Boolean,
      required: true,
    },
  },
  setup(_, { emit }) {
    const close = () => {
      emit("close");
    };

    const handleKeyup = (event: { keyCode: number }) => {
      if (event.keyCode === 27) {
        close();
      }
    };

    onMounted(() => document.addEventListener("keyup", handleKeyup));
    onUnmounted(() => document.removeEventListener("keyup", handleKeyup));

    return { close };
  },
});
</script>

<style lagn="scss" scoped>
.columns {
  position: absolute !important;
  align-content: right;
}

.close {
  border: none;
  background: none;
  font-size: 1.25em;
  font-weight: 700;
  align-items: center;
  margin: 0 0.25em;
  cursor: pointer;
}
.vue-modal {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  overflow-x: hidden;
  overflow-y: auto;
  background-color: rgba(0, 0, 0, 0.4);
  z-index: 1;
}

.vue-modal-inner {
  margin: 5em auto;
  height: auto;
  max-width: 40em;
}

.vue-modal-content {
  position: relative;
  background-color: #fff;
  border: 1px solid rgba(0, 0, 0, 0.3);
  background-clip: padding-box;
  border-radius: 0.3rem;
  padding: 1rem;
}

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.5s;
}

.fade-enter,
.fade-leave-to {
  opacity: 0;
}

.drop-in-enter-active,
.drop-in-leave-active {
  transition: all 0.3s ease-out;
}

.drop-in-enter-from,
.drop-in-leave-to {
  opacity: 0;
  transform: translate(0, -50px);
}
</style>
